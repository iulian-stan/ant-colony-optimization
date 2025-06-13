using System;
using System.Collections.Generic;
using System.Threading;

namespace ACO
{
    internal class AntSystemSolver : Solver
    {
        private readonly double _alfa;  //algorithm parameters pheromone power
        private readonly double _beta;  //algorithm parameters attraction power
        private readonly double _q;     //algorithm parameters default pheromone trail
        private readonly double _ro;    //algorithm parameters pheromone normalization power
        private readonly int _ants;
        private readonly List<List<int>> _antsPath;
        private readonly List<List<double>> _pheromones;
        private readonly Random _rand = new();
        private int _iterations;

        public AntSystemSolver(object[] args)
            : base(args)
        {
            _ants = (int)args[2];
            _iterations = (int)args[3];
            _alfa = (double)args[4];
            _beta = (double)args[5];
            _ro = (double)args[6];
            _q = (double)args[7];

            //0. Initialize pheromone level for each edge equal to 1 (same probability)
            _pheromones = new List<List<double>>(Points.Count);
            for (int i = 0; i < Points.Count; ++i)
            {
                _pheromones.Add(new List<double>(Points.Count));
                for (int j = 0; j < Points.Count; ++j)
                    _pheromones[i].Add(1);
            }

            _antsPath = new List<List<int>>(_ants);
            for (int i = 0; i < _ants; ++i)
                _antsPath.Add(new List<int>(Points.Count));
        }

        /// <summary>
        /// One step computation of the optimal path
        /// </summary>
        /// <param name="delay">time step delay between iterations</param>
        /// <param name="cost">returned path cost value (the distance)</param>
        /// <returns>stop criteria is met</returns>
        public override bool Solve(int delay, out double cost)
        {
            //1 Put each and in a random city
            for (int i = 0; i < _ants; ++i)
                ComputePath(_antsPath[i], _rand.Next(Points.Count));

            //4 Update pheromones
            //4.1 Normalize pheromone level
            foreach (var t in _pheromones)
                for (int j = 0; j < t.Count; ++j)
                    t[j] *= _ro;

            //4.2 Enforce pheromone level based on path cost
            foreach (var t in _antsPath)
            {
                cost = 0;
                for (int j = 1; j < t.Count; ++j)
                    cost += Costs[t[j - 1]][t[j]];              //compute path cost
                for (int j = 1; j < t.Count; ++j)
                    _pheromones[t[j - 1]][t[j]] += _q / cost;   //update pheromones on the path
            }

            //clear path
            CurrentPath.Clear();

            //compute path based on updated pheromone level
            ComputePath(CurrentPath, 0);

            //compute new cost
            cost = 0;
            for (int j = 1; j < CurrentPath.Count; ++j)
                cost += Costs[CurrentPath[j - 1]][CurrentPath[j]];

            //clear the path of each ant (erase their memory)
            foreach (var t in _antsPath)
                t.Clear();

            Thread.Sleep(delay);
            //5 Check stop criteria
            return (--_iterations > 0);
        }

        /// <summary>
        /// Copute the path of an ant starting fom a specified point
        /// </summary>
        /// <param name="path">the path of the ant (list of visited nodes)</param>
        /// <param name="k">starting point</param>
        private void ComputePath(List<int> path, int k)
        {
            double oldProb, newProb, sumProb;
            int next = 0;
            //Init starting point
            path.Add(k);
            //3 check if there are any unvisited nodes
            while (path.Count < Points.Count)
            {
                oldProb = sumProb = 0;
                //2 Choose next node to visit
                //2.1 Compute the sum of the force of attarction for all neighbours
                for (int j = 0; j < Points.Count; ++j)
                    if (!path.Contains(j)) //only for unvisited points
                    {
                        sumProb += Math.Pow(_pheromones[k][j], _alfa) * Math.Pow(_q / Costs[k][j], _beta);
                    }
                //2.2 Compute the probability for each neighbour and choose the best
                for (int j = 0; j < Points.Count; ++j)
                    if (!path.Contains(j)) //only for unvisited points
                    {
                        newProb = Math.Pow(_pheromones[k][j], _alfa) * Math.Pow(_q / Costs[k][j], _beta) / sumProb;
                        if (oldProb < newProb)
                        {
                            oldProb = newProb;
                            next = j;
                        }
                    }
                path.Add(next);
                k = next;
            }
        }
    }
}
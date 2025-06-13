using System.Collections.Generic;
using System.Threading;

namespace ACO
{
    internal class OptimalSolver : Solver
    {
        private readonly List<int> _optimalPath;
        private double _bestCost, _currentCost;

        public OptimalSolver(object[] args)
            : base(args)
        {
            _optimalPath = args[2] as List<int>;
            CurrentPath.Add(0); //set the home city
        }

        /// <summary>
        /// Computation of the true optimal path using backtrack algorithm
        /// </summary>
        /// <param name="delay">time step delay between iterations</param>
        /// <param name="cost">returned path cost value (the distance)</param>
        /// <returns>stop criteria is met</returns>
        public override bool Solve(int delay, out double cost)
        {
            int currentNode = CurrentPath[^1]; // get the last point from the path
            Costs[currentNode][currentNode] = 1; // mark currrent node as visited

            int next = 0;
            for (int i = 0; i < Costs[currentNode].Count; ++i)

                if (Costs[currentNode][i] < 0) // test if there was next node in the path
                {
                    Costs[i][i] = 0; //free the previous point
                    Costs[currentNode][i] *= -1; //remove the tranzition
                    _currentCost -= Costs[currentNode][i]; //remove tranzition cost
                    next = i + 1; //select next point
                    break;
                }

            while (next != Costs[currentNode].Count && (Costs[next][next] == 1 || next == currentNode))
                ++next; //exclude loop in an explored or the same node

            if (next == Costs[currentNode].Count) //if there is no option
                CurrentPath.RemoveAt(CurrentPath.Count - 1); //go back
            else //otherwise
            {
                CurrentPath.Add(next); //add the point to the path
                Costs[currentNode][next] *= -1; //mark the tranzition
                _currentCost -= Costs[currentNode][next]; //add tranzition cost

                if (_bestCost > 0 && _bestCost < _currentCost) //if the best cost is better than the current one
                    CurrentPath.RemoveAt(CurrentPath.Count - 1); //restrain from further exploration
                else if (CurrentPath.Count == Points.Count && (_bestCost == 0 || _bestCost > _currentCost))
                {
                    _bestCost = _currentCost; //update the cost
                    _optimalPath.Clear(); //clear the otimal path
                    _optimalPath.AddRange(CurrentPath); //update the optimal path
                }
            }
            cost = _bestCost;

            Thread.Sleep(delay);
            return CurrentPath.Count > 0;
        }
    }
}
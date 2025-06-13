using System;
using System.Collections.Generic;
using System.Drawing;

namespace ACO
{
    internal abstract class Solver
    {
        protected readonly List<List<double>> Costs;
        protected readonly List<int> CurrentPath;
        protected readonly List<Point> Points;

        protected Solver(object[] args)
        {
            Points = args[0] as List<Point>; // points;
            CurrentPath = args[1] as List<int>; //currentPath;

            if (Points != null)
            {
                Costs = new List<List<double>>(Points.Count); //create cost matrix
                for (int i = 0; i < Points.Count; ++i) //containing the distance
                {
                    //between each two points
                    Costs.Add(new List<double>(Points.Count));
                    foreach (Point t in Points)
                        Costs[i].Add(Math.Sqrt((Points[i].X - t.X)*(Points[i].X - t.X) +
                                               (Points[i].Y - t.Y)*(Points[i].Y - t.Y)));
                }
            }
        }

        public abstract bool Solve(int delay, out double cost);
    }
}
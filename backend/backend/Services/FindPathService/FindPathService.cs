
using System;
using System.Collections.Generic;

namespace backend.Services.FindPathService
{
    public class FindPathService
    {

    }


    public class Node : IComparable<Node>
    {
        public Node Parent;
        /// <summary>
        /// Стоимость пути до этой точки от начальной
        /// </summary>
        public double Cost;
        public double EstimatedCost;
        public Point Location;

        public int CompareTo(Node other)
        {
            return (Cost + EstimatedCost).CompareTo(other.Cost + other.EstimatedCost);
        }
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class AStar
    {
        private double[,] map;
        private PriorityQueue<Node, double> queue = new PriorityQueue<Node, double>();
        private List<Node> path = new List<Node>();
        private bool[,] visited;

        public AStar(double[,] map)
        {
            this.map = map;
            this.visited = new bool[map.GetLength(0), map.GetLength(1)];
        }

        public List<Point> FindPath(Point start, Point goal)
        {
            queue.Enqueue(new Node { Location = start }, 0);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                path.Add(current);

                if (current.Location.X == goal.X && current.Location.Y == goal.Y)
                    return GetPath();

                AddAdjacent(current, goal);
            }

            return null;  // No path
        }

        private void AddAdjacent(Node node, Point goal)
        {
            for (int x = -1; x <= 1; x++)
                for (int y = -1; y <= 1; y++)
                {
                    Point pt = new Point { X = node.Location.X + x, Y = node.Location.Y + y };

                    if (pt.X < 0 || pt.X >= map.GetLength(0) || pt.Y < 0 || pt.Y >= map.GetLength(1) || visited[pt.X, pt.Y])
                        continue;



                    double cost = node.Cost + map[pt.X, pt.Y];
                    double est = Math.Max(Math.Abs(goal.X - pt.X), Math.Abs(goal.Y - pt.Y));

                    queue.Enqueue(new Node { Location = pt, Parent = node, Cost = cost, EstimatedCost = est }, cost + est);
                    visited[pt.X, pt.Y] = true;  // Marked as visited
                }
        }

        private List<Point> GetPath()
        {
            List<Point> points = new List<Point>();
            Node node = path[path.Count - 1];

            while (node != null)
            {
                points.Insert(0, node.Location);
                node = node.Parent;
            }

            return points;

        }
    }
}

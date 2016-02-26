using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanForms
{
    public class Tree
    {
        public Node Root { get; set; }

        List<Node> nodes = new List<Node>();
        Dictionary<char, int> letters = new Dictionary<char, int>();
        public Tree()
        {
        }

        public void Build(string input)
        {
            foreach (char item in input)
            {
                if (!letters.ContainsKey(item))
                {
                    letters.Add(item, 0);
                }
                letters[item]++;
            }

            foreach (KeyValuePair<char, int> item in letters)
            {
                Node node = new Node(item.Key, item.Value);
                nodes.Add(node);
            }

            while (nodes.Count > 1)
            {
                List<Node> nodesInOrder = nodes.OrderBy(node => node.Frequency).ToList<Node>();

                if (nodesInOrder.Count > 1)
                {
                    List<Node> combine = nodesInOrder.Take(2).ToList<Node>();
                    Node parent = new Node(combine[1], combine[0]);
                    nodes.Remove(combine[0]);
                    nodes.Remove(combine[1]);
                    nodes.Add(parent);
                }
                Root = nodes.FirstOrDefault();
            }
        }

        public List<string> CreatePath(string input)
        {
            List<string> path = new List<string>();
            foreach (char item in input)
            {
                string help = "";
                path.Add(Root.Path(item, help));
            }
            return path;
        }

        public string FollowPath(List<string> path)
        {
            Node node = Root;
            string decoded = "";
            foreach (string item in path)
            {
                foreach (char bit in item)
                {
                    if (bit == '1')
                    {
                        if (node.Right != null)
                        {
                            node = node.Right;
                        }
                    }
                    else
                    {
                        if (node.Left != null)
                        {
                            node = node.Left;
                        }
                    }
                    if (!node.Parent)
                    {
                        decoded += node.Letter;
                        node = Root;
                    }
                }
            }
            return decoded;
        }
    }
}

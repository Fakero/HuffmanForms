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
        /// <summary>
        /// Palauttaa annetut merkit ja niiden määrän
        /// </summary>
        /// <returns></returns>
        public Dictionary<char, int> GetLetters()
        {
            return letters;
        }
        /// <summary>
        /// Puun rakennus
        /// </summary>
        /// <param name="input">teksti, josta puu rakennetaan</param>
        public void Build(string input)
        {
            // Haetaan merkit ja lasketaan niiden määrä
            foreach (char item in input)
            {
                if (!letters.ContainsKey(item))
                {
                    letters.Add(item, 0);
                }
                letters[item]++;
            }
            // Luodaan nodet lasketuista merkeistä
            foreach (KeyValuePair<char, int> item in letters)
            {
                Node node = new Node(item.Key, item.Value);
                nodes.Add(node);
            }
            // Rakennetaan puu
            while (nodes.Count > 1)
            {
                // Järjestetään lista
                List<Node> nodesInOrder = nodes.OrderBy(node => node.Frequency).ToList<Node>();

                if (nodesInOrder.Count > 1)
                {
                    // Otetaan 2 "pienintä" ja yhdistetään ne
                    List<Node> combine = nodesInOrder.Take(2).ToList<Node>();
                    Node parent = new Node(combine[1], combine[0]);
                    // poistetaan alkuperäiset nodet puusta ja lisätään yhdistetty node
                    nodes.Remove(combine[0]);
                    nodes.Remove(combine[1]);
                    nodes.Add(parent);
                }
                Root = nodes.FirstOrDefault();
            }
        }
        /// <summary>
        /// Pakkausmetodi
        /// </summary>
        /// <param name="input">alkuperäinen teksti, jonka mukaan reitti rakennetaan</param>
        /// <returns></returns>
        public List<string> CreatePath(string input)
        {
            List<string> path = new List<string>();
            // Rakennetaan inputin mukaan jokaiselle merkille reitti
            foreach (char item in input)
            {
                string help = "";
                path.Add(Root.Path(item, help));
            }
            return path;
        }
        /// <summary>
        /// Etsii tietyn merkin osoitteen ja palauttaa sen stringinä
        /// </summary>
        /// <param name="letter">Etsittävä merkki</param>
        /// <returns></returns>
        public string FindLetter(char letter)
        {
            Node node = Root;
            string help = "";
            string found = node.Path(letter, help);
            return found;
        }
        /// <summary>
        /// Purkumetodi
        /// </summary>
        /// <param name="path">Rakennettu reitti</param>
        /// <returns></returns>
        public string FollowPath(List<string> path)
        {
            Node node = Root;
            string followed = "";
            // käydään listaa läpi "bitti" kerrallaan ja etsitään oikea merkki
            foreach (string item in path)
            {
                foreach (char bit in item)
                {
                    if (bit == '1')
                    {
                        if (node.Right != null)
                            node = node.Right;  
                    }
                    else
                    {
                        if (node.Left != null)
                            node = node.Left;                      
                    }
                    if (!node.Parent)
                    {
                        followed += node.Letter;
                        node = Root;
                    }
                }
            }
            return followed;
        }
    }
}

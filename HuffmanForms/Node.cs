﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanForms
{
    public class Node
    {
        public int Frequency { get; set; }
        public char Letter { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public bool Parent { get; private set; }

        // Konstruktori alkuperäisille merkeille
        public Node(char letter, int frequency)
        {
            Frequency = frequency;
            Letter = letter;
            Parent = false;
        }
        // Konstruktori yhdistetyille nodeille
        public Node(Node left, Node right)
        {
            Frequency = left.Frequency + right.Frequency;
            Left = left;
            Right = right;
            Parent = true;
            Letter = '*';
        }
        /// <summary>
        /// Reitin rakennus
        /// </summary>
        /// <param name="letter">Minkä merkin reittiä etsitään</param>
        /// <param name="data">Tyhjä string, johon reitti rakennetaan</param>
        /// <returns></returns>
        public string Path(char letter, string data)
        {
            // kun merkki löytyy
            if (!Parent)
            {
                if (Letter == letter)
                    return data;
                else
                    return null;
            }
            // "bittien" lisäys merkkijonoon, riippuen mihin suuntaan mennään
            else
            {
                string left = null;
                string right = null;
                if (Left != null)
                {
                    string help = data + "0";
                    left = Left.Path(letter, help);
                }
                if (Right != null)
                {
                    string apu = data + "1";
                    right = Right.Path(letter, apu);
                }
                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}

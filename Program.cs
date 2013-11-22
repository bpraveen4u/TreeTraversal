using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeTraversal.Objects;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var structure = GetStructure();

            structure.PrintName();
            Console.ReadLine();
        }


        private static INode GetStructure()
        {
            INode root = null;

            var parent = new ParentNode("root");
            root = parent;
            parent.Add(new LeafNode("L1"));
            parent.Add(new LeafNode("L2"));

            var parent1 = new ParentNode("P1");
            parent.Add(parent1);
            //parent.Remove(parent1);
            //parent1.Parent = parent1;
            parent1.Add(new LeafNode("L3"));
            parent1.Add(new LeafNode("L4"));

            var parent2 = new ParentNode("P2");
            parent1.Add(parent2);
            parent2.Add(new LeafNode("L3"));
            parent2.Add(new LeafNode("L4"));
            //parent.Remove(parent1);
            return root;
        }
    }
}

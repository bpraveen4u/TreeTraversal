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
            var tree = GetStructure();

            //structure.PrintName();
            tree.Traverse(tree, WriteName);
            Console.ReadLine();
        }
        private static void WriteName(INode<BaseMember> node)
        {
            //node.PrintName();
            Console.WriteLine(node.Member.Name);
        }

        private static INode<BaseMember> GetStructure()
        {
            INode<BaseMember> root = null;

            var parent = new ParentNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "root" });
            
            root = parent;
            parent.Add(new LeafNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "L1" }));
            parent.Add(new LeafNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "L2" }));

            var parent1 = new ParentNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "P1" });
            parent.Add(parent1);
            //parent.Remove(parent1);
            //parent1.Parent = parent1;
            parent1.Add(new LeafNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "L3" }));
            parent1.Add(new LeafNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "L4" }));

            var parent2 = new ParentNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "P2" });
            parent1.Add(parent2);
            parent2.Add(new LeafNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "L5" }));
            parent2.Add(new LeafNode<BaseMember>(new AccountSegment() { AccountGroup = "ss", Name = "L6" }));
            //parent.Remove(parent1);
            return root;
        }
    }
}

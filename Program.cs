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


        private static INode<AccountSegment> GetStructure()
        {
            INode<AccountSegment> root = null;

            var parent = new ParentNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "root" });
            
            root = parent;
            parent.Add(new LeafNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "L1" }));
            parent.Add(new LeafNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "L2" }));

            var parent1 = new ParentNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "P1" });
            parent.Add(parent1);
            //parent.Remove(parent1);
            //parent1.Parent = parent1;
            parent1.Add(new LeafNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "L3" }));
            parent1.Add(new LeafNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "L4" }));

            var parent2 = new ParentNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "P2" });
            parent1.Add(parent2);
            parent2.Add(new LeafNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "L5" }));
            parent2.Add(new LeafNode<AccountSegment>(new AccountSegment() { AccountGroup = "ss", Name = "L6" }));
            //parent.Remove(parent1);
            return root;
        }
    }
}

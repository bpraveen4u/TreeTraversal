using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeTraversal.NewObjects;

namespace TreeTraversal
{
    class ProgramNew
    {
        public static void Main()
        {
            var seg = new AccountSegment();
            var tree = GetTree();
            tree.Traverse(Print);

            foreach (var s in tree.Flatten())
            {
                Console.WriteLine(s.Name);
            }
            Console.ReadLine();
        }

        public static void Print(TreeNode<AccountSegment> node)
        {
            Console.WriteLine("{0}_{1}_{2}", node.Value.Name, node.Parent !=null? node.Parent.Value.Name : string.Empty, node.IsLeaf);
        }

        public static TreeNode<T> GetTree<T>()
        {
            T t = Activator.CreateInstance<T>();
            var root = new TreeNode<T>(t);

            return root;
        }

        public static TreeNode<AccountSegment> GetTree()
        {
            var root = new TreeNode<AccountSegment>(new AccountSegment() { Name = "root" });
            var p = root.AddChild(new AccountSegment() { Name = "P1" });
            var p1 = p.AddChild(new AccountSegment() { Name = "P1L1" });
            var l1 = p1.AddChildren(new AccountSegment() { Name = "L1" }, 
                new AccountSegment() { Name = "L2" },
                new AccountSegment() { Name = "L3" },
                new AccountSegment() { Name = "L4" },
                new AccountSegment() { Name = "L5" });
            return root;
        }

        public abstract class BaseMember
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class AccountSegment : BaseMember
        {
            public string Type { get; set; }
            public string AccountGroup { get; set; }
        }
    }
}

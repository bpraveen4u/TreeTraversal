using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public class LeafNode<T> : INode<T> where T: BaseMember
    {
        private INode<T> parent;
        private T t;

        public LeafNode(T t)
        {
            this.t = t;
            this.Parent = null;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("--{0}_{1}", this.Member.Name, (this.Parent != null ? this.Parent.Member.Name : ""));
        }


        public INode<T> Parent
        {
            get
            {
                return parent;
            }
            set
            {
                if (this.Parent == null)
                {
                    this.parent = value;
                }
            }
        }

        public T Member
        {
            get { return t; }
        }
    }
}

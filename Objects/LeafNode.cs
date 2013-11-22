using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public class LeafNode : INode
    {
        private INode parent;

        public LeafNode(string name)
        {
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("--{0}_{1}", this.Name, (this.Parent != null ? this.Parent.Name : ""));
        }


        public INode Parent
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
    }
}

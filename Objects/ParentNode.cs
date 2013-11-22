using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public class ParentNode : INode
    {
        private List<INode> children;
        private INode parent;

        public ParentNode(string name)
        {
            children = new List<INode>();
            this.Name = name;
            this.Parent = null;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Add(INode node)
        {
            if (!children.Contains(node))
            {
                node.Parent = this;
                children.Add(node);
            }
        }

        public void Remove(INode node)
        {
            children.Remove(node);
        }

        public void PrintName()
        {
            Console.WriteLine("-{0}_{1}", this.Name, (this.Parent !=null? this.Parent.Name: ""));
            foreach (var child in children)
            {
                child.PrintName();
            }
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

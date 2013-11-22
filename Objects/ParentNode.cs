using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace TreeTraversal.Objects
{
    public class ParentNode<T> : INode<T> where T : BaseMember
    {
        private List<INode<T>> children;
        private INode<T> parent;
        private T t;

        public ParentNode(T t)
        {
            children = new List<INode<T>>();
            this.t = t;
            this.Parent = null;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Add(INode<T> node)
        {
            if (!children.Contains(node))
            {
                node.Parent = this;
                children.Add(node);
            }
        }

        public ReadOnlyCollection<INode<T>> Children { 
            get
            {
                return children.AsReadOnly();
            }
        }

        public void Remove(INode<T> node)
        {
            children.Remove(node);
        }

        public void PrintName()
        {
            Console.WriteLine("-{0}_{1}", this.Member.Name, (this.Parent !=null? this.Parent.Member.Name: ""));
            //foreach (var child in children)
            //{
            //    child.PrintName();
            //}
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


        public void Traverse(INode<T> node, TreeVisitor<T> visitor)
        {
            visitor(node);
            if (node is ParentNode<T>)
	        {
                var parentNode = node as ParentNode<T>;
		        foreach (var child in parentNode.Children)
                {
                    Traverse(child, visitor);
                }
	        }
            
        }
    }
}

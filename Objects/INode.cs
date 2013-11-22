using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public delegate void TreeVisitor<T>(INode<T> node);
    public interface INode<T>
    {
        T Member { get; }
        INode<T> Parent { get; set; }
        void Traverse(INode<T> node, TreeVisitor<T> visitor);
    }

}

﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TreeTraversal.NewObjects
{
    public class TreeNode<T>
    {
        private readonly T value;
        private readonly List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            this.value = value;
            children = new List<TreeNode<T>>();
        }

        public T Value {
            get
            {
                return value;
            }
        }

        public ReadOnlyCollection<TreeNode<T>> Children
        {
            get { return children.AsReadOnly(); }
        }

        public TreeNode<T> Parent { get; private set; }

        public bool IsLeaf { get { return !Children.Any(); } }

        public TreeNode<T> AddChild(T value)
        {
            var node = new TreeNode<T>(value) { Parent = this };
            children.Add(node);
            return node;
        }

        public TreeNode<T>[] AddChildren(params T[] values)
        {
            return values.Select(AddChild).ToArray();
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            return children.Remove(node);
        }

        //public void Traverse(Action<T> action)
        //{
        //    action(Value);
        //    foreach (var child in children)
        //        child.Traverse(action);
        //}

        public void Traverse(Action<TreeNode<T>> traverse)
        {
            traverse(this);
            foreach (var child in children)
                child.Traverse(traverse);
        }

        public IEnumerable<T> Flatten()
        {
            return new[] { Value }.Union(children.SelectMany(x => x.Flatten()));
        }       

    }
}

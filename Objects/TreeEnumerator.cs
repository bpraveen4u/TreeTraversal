using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public abstract class TreeEnumerator<T> : IEnumerator<INode<T>> where T: BaseMember
    {
        protected INode<T> tree;
        protected INode<T> current;

        public TreeEnumerator(INode<T> tree)
        {
            this.tree = tree;
        }

        public INode<T> Current
        {
            get { return current; }
        }

        public void Dispose()
        {
        }

        object System.Collections.IEnumerator.Current
        {
            get { return current; }
        }

        public abstract bool MoveNext();
       
        public void Reset()
        {
            current = null;
        }

        public virtual TreeEnumerator<T> GetEnumerator()
        {
            return this;
        }
    }

    public class SimpleTreeEnumerator<T> : TreeEnumerator<T> where T: BaseMember
    {

        public SimpleTreeEnumerator(INode<T> tree)
            : base(tree)
        {

        }

        public override bool MoveNext()
        {
            if (current == null)
            {
                current = tree;
            }
            else
            {
                //var node = current;
                //do
                //{
                    
                //} while (node.Parent == null);
            }
            return true;
        }
        
    }
}

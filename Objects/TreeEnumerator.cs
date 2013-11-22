using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public abstract class TreeEnumerator : IEnumerator<INode>
    {
        private INode tree;
        private INode current;

        public TreeEnumerator(INode tree)
        {
            this.tree = tree;
        }

        public INode Current
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

        public virtual TreeEnumerator GetEnumerator()
        {
            return this;
        }
    }


}

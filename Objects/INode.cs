using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{
    public interface INode
    {
        int Id { get; set; }
        string Name { get; set; }
        INode Parent { get; set; }
        void PrintName();
    }

    public class AccountSegment
    {
        
    }
}

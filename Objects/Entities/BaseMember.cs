using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversal.Objects
{

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

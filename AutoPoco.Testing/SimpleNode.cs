using System.Collections.Generic;

namespace AutoPoco.Testing
{
    public class SimpleNode
    {
        public SimpleNode Parent { get; set; }
        public List<SimpleNode> Children { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal interface IRectangle : IShape
    {
        double Width { get;  }
        double Height { get;  }
    }
}

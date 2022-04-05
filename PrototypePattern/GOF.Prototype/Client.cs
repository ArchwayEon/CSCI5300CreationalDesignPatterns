using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.GOF.Prototype;

public class Client
{
    public IPrototype? Original { get; set; }
    public IPrototype? Copy { get; set; }

    public void Operation()
    {
        if(Original != null)
        {
            Copy = Original.Clone();
        }
    }
}

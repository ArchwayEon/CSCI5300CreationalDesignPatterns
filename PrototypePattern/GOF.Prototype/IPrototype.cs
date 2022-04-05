using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.GOF.Prototype;

public interface IPrototype
{
    IPrototype Clone();
}


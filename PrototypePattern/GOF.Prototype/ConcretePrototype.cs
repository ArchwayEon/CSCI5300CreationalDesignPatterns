using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.GOF.Prototype;

public class ConcretePrototype1 : IPrototype
{
    public string Name { get; set; } = String.Empty;

    public IPrototype Clone()
    {
        return (IPrototype)this.MemberwiseClone();
    }
}

public class ConcretePrototype2 : IPrototype
{
    public string Id { get; set; } = String.Empty;

    public IPrototype Clone()
    {
        return (IPrototype)this.MemberwiseClone();
    }
}


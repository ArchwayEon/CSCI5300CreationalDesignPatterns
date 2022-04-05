using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.GOF.Builder;

public class ConcreteBuilder1 : IBuilder
{
    private Product _product = new();
    public void BuildPart()
    {
        _product.Name = "Part 1";
    }

    public Product GetResult()
    {
        return _product;
    }
}

public class ConcreteBuilder2 : IBuilder
{
    private Product _product = new();
    public void BuildPart()
    {
        _product.Name = "Part 2";
    }

    public Product GetResult()
    {
        return _product;
    }
}

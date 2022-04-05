using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.GOF.Builder;

public interface IBuilder
{
    void BuildPart();
    Product GetResult();
}


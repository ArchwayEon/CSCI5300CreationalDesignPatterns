using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.GOF.Builder;

public class Director
{
    public void Construct(IBuilder builder)
    {
        builder.BuildPart();
    }
}




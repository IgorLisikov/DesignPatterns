﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblem
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}

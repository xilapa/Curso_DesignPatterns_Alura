﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns1
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcular(Orcamento orcamento)
        {
            return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain
{
    public class Aluno : IEntidade
    {
        public int Matricula;
        public string Nome;
        public string CPF;
        public DateTime Nascimento;
        public EnumeradorSexo Sexo;
    }
}
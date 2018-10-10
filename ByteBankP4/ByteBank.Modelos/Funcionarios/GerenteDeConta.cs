﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }
        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
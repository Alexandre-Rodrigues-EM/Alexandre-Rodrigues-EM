using System;
using System.Collections.Generic;

namespace Apresentação_C_Sharp
{
    class Program
    {
        //Aplicação de exemplo
        //Sistema de estoque com função de entrada e saída
        static void Main(string[] args)
        {
            Produto leite = new Perecivel(1, "leite", "17/06/2021");
            
            Produto carne = new Produto();
            carne = new Perecivel(2, "carne", "10/06/2021");

            carne.entradaEstoque(20);

            
            foreach(var p in )
            Console.WriteLine("Quantidade de {0}: {1}", carne.nomeProduto, carne.quantidadeProduto);

        }
    }
}

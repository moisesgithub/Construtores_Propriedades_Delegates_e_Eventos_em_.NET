﻿using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;//uma constante não pode ser alterada
            System.Console.WriteLine(pi);
            
            //Data data = new Data();
            //data.SetMes(20);

            //data.Mes = 20;

            //System.Console.WriteLine(data.Mes);

            //data.ApresentarMes();
            
            /*Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);*/

            
            //Aluno p1 = new Aluno("Moises", "Pereira", "Teste");
            //p1.Apresentar();
        }
    }
}

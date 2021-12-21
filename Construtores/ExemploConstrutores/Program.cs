using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.SetMes(20);

            data.ApresentarMes();
            
            /*Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);*/

            
            //Aluno p1 = new Aluno("Moises", "Pereira", "Teste");
            //p1.Apresentar();
        }
    }
}

using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
            
            //Operacao op = Calculadora.Somar;
            //op(10, 20); ou
            //Operacao op = new Operacao(Calculadora.Subtrair);
            //op += Calculadora.Somar;
            // adicionando uma extensão multi-cast Delegate, chamando a função somar e subtrair

            //op.Invoke(50, 20);
                        
            //const double pi = 3.14;//uma constante não pode ser alterada
            //System.Console.WriteLine(pi);
            
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

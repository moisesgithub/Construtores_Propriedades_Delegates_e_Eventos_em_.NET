namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            //Calculadora.EventoCalculadora += EventHandler;//método inscrito no evento
        }
        public void Somar()
        {
            Calculadora.Somar(X, Y);        
        }
        public void EventHandler()//método executado após o termino da ação
        {
            System.Console.WriteLine("Método Executado");
        }
    
    }
}
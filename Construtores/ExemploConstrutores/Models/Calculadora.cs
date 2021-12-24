namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();//delegate
        public static event DelegateCalculadora EventoCalculadora;
        //evento de classe, aqui outros objetos podem se inscrever nesse evento
        public static void Somar(int x, int y)//o método vai executar a adição pra mim e executar o evento
        {
            if(EventoCalculadora != null)
            {
               System.Console.WriteLine($"Adição: {x + y}");
               EventoCalculadora();
            }        
            else
            {
               System.Console.WriteLine("Nenhum inscrito");
            }
        }        
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}
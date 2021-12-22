namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Moises";
        //readonly só pode na inicialização e dentro do construtor
        private readonly string sobrenome;

        /*public Pessoa()

        {
           nome = string.Empty;
           sobrenome = string.Empty;    
        }*/
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor da classe Pessoa");
        }
        public void Apresentar()
        {            
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }      
    }
}
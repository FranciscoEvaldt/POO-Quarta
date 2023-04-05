using Aula_06;

class Program
{
    static void Main(string[] args)
    {
        Animal cachorro = new Cachorro("Bolinha");
        cachorro.Falar();

        Animal gato = new Gato("Frajola");
        gato.Falar();
    }
}

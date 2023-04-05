using Aula_06_3;
class Program
{
    static void Main(string[] args)
    {
        Personagem personagem1 = new Personagem("Personagem 1", 50, 50, new string[] { "Poder 1", "Poder 2" });
        personagem1.Lutar();

        Heroi heroi1 = new Heroi("Herói 1", 80, 60, new string[] { "Poder 1", "Poder 2", "Poder 3" });
        heroi1.Lutar();

        Vilao vilao1 = new Vilao("Vilão 1", 70, 90, new string[] { "Poder 1", "Poder 2", "Poder 3", "Poder 4" });
        vilao1.Lutar();

        SuperHeroi superHeroi1 = new SuperHeroi("Super Herói 1", 90, 80, new string[] { "Poder 1", "Poder 2", "Poder 3", "Poder 4", "Poder 5"});
        superHeroi1.Lutar();
    }    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_3{
    using System;

    class Personagem{
        public string Nome;
        public int Forca;
        public int Inteligencia;
        public string[] Poderes;

        public Personagem(string nome, int forca, int inteligencia, string[] poderes){
            Nome = nome;
            Forca = forca;
            Inteligencia = inteligencia;
            Poderes = poderes;
        }

        public virtual void Lutar(){
            Console.WriteLine("{0} está lutando usando seus poderes: {1}", Nome, string.Join(", ", Poderes));
        }
    }

    class Heroi : Personagem{
        public Heroi(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes){
        }

        public override void Lutar(){
            Console.WriteLine("{0} está lutando heroicamente usando seus poderes: {1}", Nome, string.Join(", ", Poderes));
        }
    }

    class Vilao : Personagem{
        public Vilao(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes){
        }

        public override void Lutar(){
            Console.WriteLine("{0} está lutando de forma maléfica usando seus poderes: {1}", Nome, string.Join(", ", Poderes));
        }
    }

    class SuperHeroi : Heroi{
        public string SuperPoder;

        public SuperHeroi(string nome, int forca, int inteligencia, string[] poderes) : base(nome, forca, inteligencia, poderes)
        {
        }

        public SuperHeroi(string nome, int forca, int inteligencia, string[] poderes, string superPoder) : base(nome, forca, inteligencia, poderes){
            SuperPoder = superPoder;
        }

        public void SuperPoder(){
            Console.WriteLine("{0} está usando seu super poder: {1}", Nome, SuperPoder);
        }
    }

    class SuperVilao : Vilao{
        public string SuperPoder;

        public SuperVilao(string nome, int forca, int inteligencia, string[] poderes, string superPoder) : base(nome, forca, inteligencia, poderes){
            SuperPoder = superPoder;
        }

        public void SuperPoder(){
            Console.WriteLine("{0} está usando seu super poder: {1}", Nome, SuperPoder);
        }
    }
}

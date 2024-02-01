using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    public class Personagem
    {
        protected string Nome { get; set; }
        protected string Categoria { get; set; }
        protected int Nivel { get; set; }
        protected int Forca { get; set; }
        protected int Agilidade { get; set; }
        protected int Inteligencia { get; set; }
        protected int Vida { get; set; }
        public Personagem(string nome, string categoria, int nivel, int forca, int agilidade,
            int inteligencia, int vida)
        {
            Nome = nome;
            Categoria = categoria;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }
        public void ApresentarSe()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine($"Categoria: {Categoria}");
            Console.WriteLine("Nível: {0}", Nivel);
            Console.WriteLine("Força: {0}", Forca);
            Console.WriteLine("Agilidade: {0}", Agilidade);
            Console.WriteLine("Inteligência: {0}", Inteligencia);
            Console.WriteLine("Vida: {0} \n", Vida);
        }

        public int Atacar(Personagem p)
        {
            int ataque = (Forca + Agilidade + Inteligencia + Nivel) / 4;
            Console.WriteLine($"{Nome} atacou {p.Nome} com poder de Ataque {ataque}");
            return ataque;
        }

        public int Defender(Personagem p)
        {
            int defesa = (Forca + Agilidade + Inteligencia + Nivel) / 4;
            Console.WriteLine($"{Nome} defendeu {p.Nome} com poder de Defesa {defesa}");
            return defesa;
        }

        public void Duelo(Personagem p)
        {
            Console.WriteLine($"{Nome} está enfrentando {p.Nome}!\n");
            while (this.Vida > 0 && p.Vida > 0)
            {
                int ataque = Atacar(p);
                int defesa = p.Defender(this);
                int dano = ataque - defesa;
                if (ataque > defesa)
                {
                    Console.WriteLine($"{Nome} atacou o {p.Nome} com dano de {dano} pontos de vida!");
                    p.Vida -= dano;
                    Console.WriteLine($"{Nome} está com {Vida} pontos de vida!\n");
                }
                else
                {
                    Console.WriteLine($"{p.Nome} defendeu o Ataque de {Nome}!");
                    p.Vida--;
                    Console.WriteLine($"{Nome} está com {Vida} pontos de vida!\n");
                }

                int contraAtaque = p.Atacar(this);
                int contraDefesa = Defender(p);
                int contraDano = contraAtaque - contraDefesa;
                if (contraAtaque > contraDefesa)
                {
                    Console.WriteLine($"{p.Nome} atacou o {Nome} com dano de {contraDano} pontos de vida!");
                    Vida -= contraDano;
                    Console.WriteLine($"{p.Nome} está com {p.Vida} pontos de vida!\n");
                }
                else
                {
                    Console.WriteLine($"{Nome} defendeu o Ataque de {p.Nome}!");
                    Vida--;
                    Console.WriteLine($"{p.Nome} está com {p.Vida} pontos de vida!\n");
                }
            }

            if (Vida <= 0)
            {
                Console.WriteLine($"{p.Nome} venceu o duelo!");
                p.Nivel++;
                Console.WriteLine($"{p.Nome} subiu para o nível {p.Nivel}!\n");
            }
            else
            {
                Console.WriteLine($"{Nome} venceu o duelo!");
                Nivel++;
                Console.WriteLine($"{Nome} subiu para o nível {Nivel}!\n");
            }
        }

    }
}

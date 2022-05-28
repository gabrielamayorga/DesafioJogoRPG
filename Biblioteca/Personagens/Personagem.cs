using System;

namespace Biblioteca
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Força { get; set; }
        public int Inteligencia { get; set; }
    }
}

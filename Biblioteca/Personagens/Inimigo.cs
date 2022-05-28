using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Inimigo : Personagem
    {
        public int RecompensaExperiencia { get; set; }
        public int RecompensaDinheiro { get; set; }
        public List<Item> Recompensaitem { get; set; }
    }
}

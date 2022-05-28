using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Missao
    {
        public List <Inimigo> Inimigos { get; set; }

        public int RecompensaExperiencia { get; set; }
        public int RecompensaDinheiro { get; set; }
        public List <Item> Recompensaitem { get; set; }
    }
}

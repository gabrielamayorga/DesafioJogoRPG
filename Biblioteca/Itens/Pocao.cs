using System;

namespace Biblioteca
{
    public abstract class Pocao : Item
    {
       public int AumentarVida { get; set; }
       public int Cura { get; set; }
       public int Agilidade { get; set; }

        public override string ObterDescricao()
        {
            return $"Aumentar Vida: {AumentarVida}, Cura: {Cura}, Agilidade: {Agilidade}";
        }
    }
}

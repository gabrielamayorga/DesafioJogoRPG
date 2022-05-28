using System;

namespace Biblioteca
{
    public abstract class Roupas : Item
    {
       public int Protecao {get; set; }

        public override string ObterDescricao()
        {
            return $"Proteção: {Protecao}";
        }
    }
}

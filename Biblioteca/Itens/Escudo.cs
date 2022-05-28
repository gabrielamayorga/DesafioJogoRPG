using System;

namespace Biblioteca
{
    public abstract class Escudo : Item
    {
       public int Protecao { get; set; }

        public override string ObterDescricao()
        {
            return $"Escudo: {Nome}, Proteção: {Protecao}";
        }
    }
}

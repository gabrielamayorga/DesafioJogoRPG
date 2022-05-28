using System;

namespace Biblioteca
{
    public class Arma : Item
    {
        public int Dano { get; set; }


        public override string ObterDescricao()
        {
            return $"Arma: {Nome}, Dano: {Dano}";
        }
    }
}

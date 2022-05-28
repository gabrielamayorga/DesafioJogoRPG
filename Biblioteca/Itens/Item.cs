using System;

namespace Biblioteca
{
    public abstract class Item
    {
       public string Nome { get; set; }
       public string Tipo { get; set; }

        public virtual string ObterDescricao()
        {
            return Nome;
        }
    }
}

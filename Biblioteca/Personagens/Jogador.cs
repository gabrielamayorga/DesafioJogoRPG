using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Jogador : Personagem
    {
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public List <Item> Itens { get; set; }
        public Profissao Profissao { get; set;}
        public List <Missao> Missaos { get; set; }
    }
}

using GameTOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTop.Lib
{
    public class Jogador1: iJogador
    {

        private readonly string _Nome;
        public Jogador1(string nome = "Vitinho")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está Chutando";
        }
        public string Corre()
        {
           return $"{_Nome} está Correndo";
        }
        public string Passe()
        {
           return $"{_Nome} está Passando";
        }

    }

}


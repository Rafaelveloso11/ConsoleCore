using GameTOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Ribamar está Chutando";
        }

        public string Corre()
        {
            return "Ribamar está Correndo";
        }

        public string Passe()
        {
            return "Ribamar está Passando";
        }
    }
}

using GameTop.Lib;
using System;
using static GameTop.JogoDivertido;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoDivertido(new Jogador1(),new Jogador2()); 
         
            jogo.IniciarJogo();
        }
    }

    

}

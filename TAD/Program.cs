﻿using System;
using Struct;

namespace TAD {
    class Program {
        static void Main(string[] args) {
            ClienteS cliente1 = new("Arthur", "404.974.278-00", "zenaboa7@gmail.com", "29/03/2006");

            Console.WriteLine(cliente1.Imprimir());

            JogadorFutebol jogador = new("Pedro", "Vasco", "Lateral Direito", 5, 2);
            jogador.RegistarNumeroCartoesAmarelos(2);
            Console.WriteLine(jogador.Imprimir());


        }
    }
}
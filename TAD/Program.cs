﻿using System;
using Struct;

namespace TAD {
    class Program {
        static void Main(string[] args) {
            // ClienteS cliente1 = new("Arthur", "404.974.278-00", "zenaboa7@gmail.com", "29/03/2006");
            // Console.WriteLine(cliente1.Imprimir());

            // JogadorFutebol jogador = new("Pedro", "Vasco", "Lateral Direito", 5, 2);
            // jogador.RegistarNumeroCartoesAmarelos(2);
            // Console.WriteLine(jogador.Imprimir());

            // EquipeEsports equipe = new("APS", 2022, 4, 87330.50f);
            // Console.WriteLine(equipe.VerificarAnoEstreia());
            // equipe.RegistrarCampeonatoVencido(1000);
            
            // Console.WriteLine(equipe.Imprimir());
            // Produto produto = new Produto("Cerveja", 100, 15.99f);
            // Console.WriteLine(produto.AplicarCupomDeDescontoValor(10));
            // Console.WriteLine(produto.AplicarCupomDescontoPorcentagem(0.10f));
            // Console.WriteLine(produto.VerificarQuantidadeEmEstoque());
            // Console.WriteLine(produto.Imprimir());

            Professor professor = new Professor("Arthur", 1000, 80, 5);

            Console.WriteLine(professor.Imprimir());

        }
    }
}
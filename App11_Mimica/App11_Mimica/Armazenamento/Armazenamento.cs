using System;
using System.Collections.Generic;
using System.Text;
using App11_Mimica.Model;

namespace App11_Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras = {
            //Fac Pontos 1
            new string[] {"Olho","Lingua","Chinelo","Milho","Penalti","Bola","Ping-Pong"},

            //Med Pontos 3
            new string[] {"Carpinteiro","Amarelo","Limão","Abelha"},

            //Dif Pontos 5
            new string[] {"Cisterna","Lanterna","Batman vs Superman","Notebook","Cinema"}
        };

    }
}

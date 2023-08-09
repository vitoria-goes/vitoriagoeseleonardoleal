using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class jogador
    {
        string nome;
        int idade;
        int drible;
        int velocidade;
        int chute;
        int força;

        public void correr()
        {
            int aceleracao = força + velocidade;
        }

        public int chutar()
        {
            int potenciachute = força * chute;

            return potenciachute;
        }
           
        public double tocar()
        {
            double toque = chute / 3 +  força / 3;

            return toque;
        }

        public double interceptar()
        {
            double potenciacarrinho = velocidade * velocidade + força / 2;

            return potenciacarrinho;
        }
        public double driblar()
        {
            double eficaciadrible = drible + (velocidade) ^ 2;

            return eficaciadrible;
        }
    }


}   
    
    


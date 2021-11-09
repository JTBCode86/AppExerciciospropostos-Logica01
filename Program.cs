using System;

namespace AppExerciciospropostos_Logica01
{
    class Program
    {
        /// <summary>
        /// Exercicio 01 
        /// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma 
        /// desses números com uma 
        /// mensagem explicativa, conforme exemplos
        /// </summary>
        
        public static int Calcular(int A, int B) 
        {
            int resultado;
            try
            {
                resultado = (A + B);
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            int valorA;
            int valorB;
            
            Console.WriteLine("Entre com os valores para serem somados: ");
            string[] vet = Console.ReadLine().Split(' ');

            valorA = int.Parse(vet[0]);
            valorB = int.Parse(vet[1]);

            int resultadoCalculo = Calcular(valorA, valorB);

            Console.WriteLine("A soma dos valores é igual a: {0}", resultadoCalculo);
            Console.ReadLine();

        }
    }
}

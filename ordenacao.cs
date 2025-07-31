using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula
{
    internal class Util
    {

        public static void popularAleatorioNumeros(List<int> lista, long quantidade, int inicio, int fim)
        {
            Random gerador = new Random();
            for (; quantidade > 0; quantidade--)
            {
                lista.Add(gerador.Next(inicio, fim));
            }
        }


        public static void exibirListaNumeros(List<int> lista)
        {
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
        }


        public static void popularAleatorioPalavras(List<string> lista, long quantidade, int tamanho)
        {
            string letras = "abcdefghijklmnopqrstuvwxyz";
            Random gerador = new Random();

            for (; quantidade > 0; quantidade--)
            {
                string palavraGerada = "";
                char letraSorteada;
                for (int i = 0; i < tamanho; i++)
                {
                    letraSorteada = letras[gerador.Next(letras.Length)];
                    palavraGerada = palavraGerada + letraSorteada;

                }
                lista.Add(palavraGerada);

            }
        }

        public static void exibirListaPalavras(List<string> lista)
        {
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information

using aula;

    List<int> listaNumeros = new List<int>();
    List<int> lista2Numeros = new List<int>();

    List<string> listaPalavras = new List<string>();

    Util.popularAleatorioNumeros(listaNumeros, 10, 100, 500);
    Util.exibirListaNumeros(listaNumeros);

    lista2Numeros.AddRange(listaNumeros);

    Util.popularAleatorioPalavras(listaPalavras, 10, 6);
    Util.exibirListaPalavras(listaPalavras);








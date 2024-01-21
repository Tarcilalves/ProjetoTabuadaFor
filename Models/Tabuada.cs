using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoTabuadaFor.Models
{
      public class Tabuada
    {
        private int numBase = 0;
        private List<string> tabuadaLista = new List<string>();

        public void Multiplicar()
        {
            Console.WriteLine($"Tabuada do {numBase}");

            for (int contador = 1; contador <= 10; contador++)
            {
                string resultado = $"{numBase} X {contador} = {numBase * contador}";
                
                Console.WriteLine(resultado);
                tabuadaLista.Add(resultado);
                
            }
            Console.WriteLine(); 
        }

        public Tabuada(int numBase)
        {
            this.numBase = numBase;
        }

        public void AdicionarTabuada()
        {
            Console.Write("Digite o número base da tabuada: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numBase = num;
                Console.WriteLine($"Tabuada do {numBase} adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
            Console.WriteLine(); 
        }    

        public void LimparLista()
        {
            tabuadaLista.Clear();
            Console.WriteLine("Lista de tabuadas foi limpa.");
        }

        public void ListarTabuadas()
        {
            if (tabuadaLista.Any())
            {
                Console.WriteLine("As tabuadas realizadas são: \n");
                foreach (var tabuada in tabuadaLista)
                {
                    Console.WriteLine(tabuada);
                }
            }
            else
            {
                Console.WriteLine("Não há nenhuma tabuada.");
            }
            
            Console.WriteLine(); 
        }

        // Construtor vazio
        public Tabuada()
        {
        }
    }
}

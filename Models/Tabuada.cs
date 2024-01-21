using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoTabuadaFor.Models
{
      public class Tabuada
    {
        private int numBase = 0; //Declarando váriavel do tipo 'private'         
        private List<string> tabuadaLista = new List<string>(); //Lista do tipo string é declarada e inicializada.  
        //Essa lista é utilizada para armarzenar as tabuadas gerada pelo programa.


        //Método: é responsável por calcular a tabuada do número armazenado em numBase 
        //e exibir os resultados no console. Também adiciona cada resultado à lista 
        //tabuadaLista.
        public void Multiplicar()
        {
            Console.WriteLine($"Tabuada do {numBase}"); // imprime no console a mensagem indicando qual é o número da tabuada que está sendo exibida.

            //Este é um loop é utilizado para percorrer os multiplicadores de 1 a 10.

            for (int contador = 1; contador <= 10; contador++)
            {
                //string chamada 'resultado' é criada utilizando interpolação de string para formar a expressão da multiplicação e o resultado correspondente.
                string resultado = $"{numBase} X {contador} = {numBase * contador}";
                
                Console.WriteLine(resultado); // Esta linha exibe no console cada linha da tabuada, mostrando a multiplicação e o resultado correspondente.
                tabuadaLista.Add(resultado); //Adiciona a string resultado à lista tabuadaLista
                
            }
            Console.WriteLine(); //é adicionada uma linha em branco
        }

        //Construtor é chamado quando uma instância é criado
        public Tabuada(int numBase)
        {
            this.numBase = numBase;
        }

        // Método: 
        public void AdicionarTabuada()
        {
            Console.Write("Digite o número base da tabuada: "); // Método para obter a entrada do usuário e o try.Parse tenta converter essa string em um número inteito.
            // O try.Parse trata a a exceção caso acha uma. 
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
            tabuadaLista.Clear(); // método para limpar a lista 
            Console.WriteLine("Lista de tabuadas foi limpa.");
        }

        public void ListarTabuadas()
        {
            if (tabuadaLista.Any()) // O método Any() é um método da classe System.Linq.Enumerable que verifica se há algum elemento na sequência (neste caso, a lista tabuadaLista). Retorna true se houver pelo menos um elemento na lista e false se a lista estiver vazia.
            //O bloco de código dentro do if é executado se a lista tabuadaLista não estiver vazia. Isso significa que há tabuadas na lista.
            {
                Console.WriteLine("As tabuadas realizadas são: \n");
                foreach (var tabuada in tabuadaLista) // Itera sobre cada elemento da lista 
                {
                    Console.WriteLine($"{tabuada}\t");
                }
            }
            else
            {
                Console.WriteLine("Não há nenhuma tabuada.");
            }
            
            Console.WriteLine(); 
        }

        // Construtor vazio
        public Tabuada() //um construtor vazio é adicionado para garantir que sempre haja a opção de criar uma instância da classe sem a necessidade de fornecer argumentos para um construtor.
        {
        }
    }
}






<h1 align="left">
  <img src="https://github.com/Tarcilalves/ProjetoCalculadora/assets/107896645/759d337e-ad24-416d-b2df-c6e933e2a8e8" width="30px" alt="6231036"> 
  Projeto Tabuada 
</h1>

# Índice

* [Percurso](#Percurso)
* [Objetivo](#Objetivo)
* [Ferramentas](#Ferramentas)
* [Funcionalidades em Detalhes](#Funcionalidades-em-Detalhes)
* [Funcionalidades do Projeto Vídeo](#Funcionalidades-do-Projeto-Vídeo)
* [Links Úteis](#Links-Úteis)
* [Pessoas Desenvolvedoras do Projeto](#Pessoas-Desenvolvedoras-do-Projeto)

# Percurso
<table>
  </thead>
  <tbody align="left">
    <tr>
      <td>01</td>
      <td>Estrutura de Repetição For</td>
    </tr>
    <tr>
      <td>02</td>
      <td>Estrutura de Repetição While</td>     
    </tr>
    <tr>
      <td>02</td>
      <td>Switch Case</td>     
    </tr>
    <tr>
      <td>03</td>
      <td>Links úteis</td>  
    </tr>    
  </tbody>
  <tfoot>
</table>

# Objetivo 🎯

> O objetivo deste projeto é aprimorar os conceitos fundamentais adquiridos durante as aulas por meio da implementação prática em um contexto de programação.
> O escopo do projeto envolve o desenvolvimento de um programa capaz de calcular tabuadas utilizando uma estrutura de loop para iterar sobre os multiplicadores no intervalo de 1 a 10.

Adicionalmente, foram incorporadas implementações extras com o intuito de enriquecer a funcionalidade do programa, destacando-se:

- **Menu Interativo:**
Introdução de uma interface interativa que possibilita a seleção de diferentes operações no programa, proporcionando uma experiência mais dinâmica e amigável ao usuário.

- **Lista para Armazenamento de Solicitações de Cálculos da Tabuada:**
Implementação de uma lista para armazenar de maneira estruturada as solicitações de cálculos das tabuadas realizadas durante a execução do programa. Isso permite o acesso e a consulta posterior das tabuadas calculadas.

- **Funcionalidade de Limpar Lista:**
Adição de uma funcionalidade que permite a remoção de elementos da lista, proporcionando ao usuário a capacidade de gerenciar e manter registros organizados.
A combinação dessas funcionalidades visa consolidar o entendimento teórico por meio de uma aplicação prática, promovendo uma abordagem holística do aprendizado. O projeto visa não apenas reforçar os conhecimentos adquiridos, mas também fornecer uma base sólida para futuros desenvolvimentos e desafios no âmbito da programação.


# Ferramentas 🛠️
[![GitHub](https://img.shields.io/badge/GitHub-000?style=for-the-badge&logo=github&logoColor=30A3DC)](https://docs.github.com/)
[![Git](https://img.shields.io/badge/Git-000?style=for-the-badge&logo=git&logoColor=E94D5F)](https://git-scm.com/doc) 
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-000?style=for-the-badge&logo=windows&logoColor=2CA5E0)
![Vscode](https://img.shields.io/badge/Vscode-007ACC?style=for-the-badge&logo=visual-studio-code&logoColor=white)


# Funcionalidades em Detalhes

<img src="https://github.com/Tarcilalves/ProjetoTabuadaFor/assets/107896645/f55774af-a1e4-461d-90d0-58effd3da0f0" alt="Classe Tabuada"  width="300px" align="center"> <br><br>

**Classe Tabuada responsável por calcular e gerenciar tabuadas.**
> Declarações de campos (ou atributos) na classe Tabuada
- **private int numBase = 0;**
- **private List<string> tabuadaLista = new List<string>();** Lista do tipo string é declarada e inicializada. Essa lista é utilizada para armarzenar as tabuadas gerada pelo programa.


> Métodos da Classe Tabuada:
- **Método Multiplicar** : é responsável por calcular a tabuada do número armazenado em 'numBase' e exibir os resultados no console. Também adiciona cada resultado à lista tabuadaLista.
```
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
  ```
- **Método Adicionar Tabuada**: este método solicita ao usuário que insira um número inteiro para ser usado como o número base para calcular a tabuada. Se a entrada for válida, a tabuada é adicionada com sucesso, caso contrário, é exibida uma mensagem de erro.
> Método para obter a entrada do usuário e o try.Parse tenta converter essa string em um número inteito.O try.Parse trata a a exceção caso acha uma. 

```
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
```

- **ListarTabuadas**: o método ListarTabuadas verifica se há tabuadas na lista e as exibe no console. Se a lista estiver vazia, ele exibe uma mensagem indicando que não há tabuadas. O uso do método Any() é fundamental aqui para determinar se a lista contém algum elemento antes de tentar iterar sobre ela.
> O método Any() é um método da classe System.Linq.Enumerable que verifica se há algum elemento na sequência (neste caso, a lista tabuadaLista).
> Retorna true se houver pelo menos um elemento na lista e false se a lista estiver vazia.
> O bloco de código dentro do if é executado se a lista tabuadaLista não estiver vazia. Isso significa que há tabuadas na lista.

```
 public void ListarTabuadas()
        {
            if (tabuadaLista.Any()) 
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
```
- **LimparLista**: Isso limpará o console, removendo todo o conteúdo anterior e deixando uma tela em branco.
```
public void LimparLista()
        {
            tabuadaLista.Clear(); // método para limpar a lista 
            Console.WriteLine("Lista de tabuadas foi limpa.");
        }
```
<h2>
  Objeto Tabuada
</h2>

A **Classe Tabuada** é criado para possibilitar a execução das operações relacionadas às tabuadas.
```

   Tabuada tab = new();

```

- Menu interativo:
> O sistema de menu interativo foi implementado utilizando a estrutura de controle de fluxo while, proporcionando iterações contínuas até que uma condição de saída seja satisfeita. Dentro dessa estrutura, foi empregada a instrução switch para facilitar o acesso às diferentes opções disponíveis no menu. Essa abordagem confere flexibilidade e facilidade de navegação ao usuário, permitindo a escolha entre diversas funcionalidades por meio de uma interface intuitiva.
```
 // Realizar o loop do Menu
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Calcular Tabuada");
                Console.WriteLine("2 - Listar tabuada");
                Console.WriteLine("3 - Limpar lista de tabuadas");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        tab.AdicionarTabuada();
                        tab.Multiplicar();
                        break;                    

                    case "2":
                        tab.ListarTabuadas();
                        break;

                    case "3":
                        tab.LimparLista();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
```
# Funcionalidades do Projeto Vídeo



https://github.com/Tarcilalves/ProjetoTabuadaFor/assets/107896645/a2cebd73-73f5-4877-aa93-f4eb65e887c5


# Links Úteis

[Microsoft-language-reference](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/iteration-statements) 
<br>
[wellsb](https://wellsb.com/csharp/beginners/create-menu-csharp-console-application)
<br>
[programiz-do-while-loop](https://www.programiz.com/csharp-programming/do-while-loop)
<br>
[bestprog-do-while-loop](https://www.bestprog.net/en/2019/11/13/c-the-do-while-loop-examples-of-using/)




# Pessoas Desenvolvedoras do Projeto

|<img src="https://github.com/Tarcilalves/ProjetoCalculadora/assets/107896645/8a70a052-692d-4513-ad32-0b07089f8734" width="30%" alt="fo" align="left">|
|--|
|<p align="left">Tarcila Alves</p>| 

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/tarcilacardosoalves/) 	[![Instagram](https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/tarcilacardosoalves/)









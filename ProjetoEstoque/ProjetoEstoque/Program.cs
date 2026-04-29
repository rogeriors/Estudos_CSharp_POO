using System;
using System.Globalization;

namespace ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Criação do objeto Estoque com os dados fornecidos
            Estoque produto = new Estoque(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto : {produto}");

            // Menu de opções para adicionar ou remover produtos do estoque
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar produtos ao estoque");
            Console.WriteLine("2 - Remover produtos do estoque");
            Console.WriteLine("3 - Sair");
            int opcao = int.Parse(Console.ReadLine());

            // Validação da opção escolhida
            while (opcao < 1 || opcao > 3)
            {
                Console.Clear();
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine($"Quantidade no estoque: {produto.Quantidade}");

                Console.WriteLine();
                Console.WriteLine("Opção inválida. Digite novamente: ");

                Console.WriteLine();
                Console.WriteLine("1 - Adicionar produtos ao estoque");
                Console.WriteLine("2 - Remover produtos do estoque");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());
            }

            // Loop para adicionar ou remover produtos do estoque
            while (opcao != 3)
            {
                if (opcao == 1)
                {
                    Console.WriteLine();
                    Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                    int qte = int.Parse(Console.ReadLine());
                    produto.AdicionarProdutos(qte);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine();
                    Console.Write("Digite o número de produtos a ser removiodo do estoque: ");
                    int remove = int.Parse(Console.ReadLine());
                    produto.RemoverProdutos(remove);
                }

                // Atualização dos dados do produto após a operação
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Dados atualizados: {produto}");

                Console.WriteLine();
                Console.WriteLine("1 - Adicionar produtos ao estoque");
                Console.WriteLine("2 - Remover produtos do estoque");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());

                // Validação da opção escolhida dentro do loop
                while (opcao < 1 || opcao > 3)
                {
                    Console.Clear();
                    Console.WriteLine($"Nome: {produto.Nome}");
                    Console.WriteLine($"Preço: {produto.Preco}");
                    Console.WriteLine($"Quantidade no estoque: {produto.Quantidade}");

                    Console.WriteLine();
                    Console.WriteLine("Opção inválida. Digite novamente: ");

                    Console.WriteLine();
                    Console.WriteLine("1 - Adicionar produtos ao estoque");
                    Console.WriteLine("2 - Remover produtos do estoque");
                    Console.WriteLine("3 - Sair");
                    opcao = int.Parse(Console.ReadLine());
                }

            }
            // Mensagem de saída do programa
            Console.WriteLine();
            Console.WriteLine("Saindo do programa...");
        }
    }
}
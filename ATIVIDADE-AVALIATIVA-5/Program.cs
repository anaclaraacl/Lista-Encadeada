class Program
{
    private static void Main(string[] args)
    {
        Lista lista = new Lista();
        int opcao;

        do
        {
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Pesquisar");
            Console.WriteLine("3 - Imprimir Lista");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida.");
                continue;
            }

            switch(opcao)
            {
                case 1:
                   
                    Console.Write("Digite uma chave: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine();

                    if (lista.procurar(id) >= 0)
                    {
                        Console.WriteLine("A chave já existe na lista. Digite outro valor para chave");
                    } else
                    {
                        lista.inserir(id, nome);

                    }
                    break;
                case 2:
                    Console.Write("Qual a chave que você deseja pesquisar: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (lista.procurar(id) >= 0)
                    {
                        Console.WriteLine("Nome: " + lista.procurarNome(id));
                        
                        Console.Write("Deseja remover o nó da lista (S/N)?");
                        string resposta = Console.ReadLine();

                        if(resposta == "S")
                        {
                            lista.remover(id);
                            Console.WriteLine("O nó foi removido.");
                        }
                        
                    } else
                    {
                        Console.WriteLine("A chave não existe na lista.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Lista: ");
                    lista.imprimir();
                    break;
                case 4:
                    Console.WriteLine("Saindo do sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine();
                    break;
            }

        } while (opcao != 4);
    }
}

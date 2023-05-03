
using AtividadeCodificacao.Classes;

string opcao = "";
PessoaJuridica metodosPJ = new PessoaJuridica();
do
{
    //Limpar o que está escrito no terminal
    Console.Clear();

    // Escreve o menu
    Console.WriteLine(@"

    1 - Cadastrar PJ
    2 - Listar PJ
    3 - Sair
    ");

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        // Cadastrar uma nova pessoa Juridica
        case "1":
           PessoaJuridica pj = new PessoaJuridica();

           Console.WriteLine("Informe o nome da PJ: ");

            pj.Nome = Console.ReadLine();

            Console.WriteLine("Informe o rendimento da PJ:");

            pj.Rendimento = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe o CNPJ:");

            pj.Cnpj = Console.ReadLine();

            metodosPJ.Inserir(pj);

            // Mensagem de sucesso
            Console.WriteLine("Pessoa Juridica cadastra com sucesso!");

            // Esperar uma tecla ser digitada
            Console.ReadLine();


            break;

        // Listar uma pessoa juridica
        case "2":
            
            // Pergunta o nome da PJ
            Console.WriteLine("Digite o nome da PJ:");

            // Lê o nome da PJ
            string nomePJ = Console.ReadLine()!;

            // Uso o método ler para recuparar oque está no arquivo .txt
            PessoaJuridica pjLeitura = metodosPJ.Ler(nomePJ);

            // Apresento os dados da PJ
            Console.WriteLine(@$"

                Nome: {pjLeitura.Nome}
                Rendimento: R${pjLeitura.Rendimento},00
                Cpnj: {pjLeitura.Cnpj}
            ");
            Console.ReadLine();
            break;
        default:
            break;
    }
    
} while (opcao != "3");
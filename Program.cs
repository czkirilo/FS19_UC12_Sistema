using FS19_UC12_Sistema.Classes;

class Program{
    static void Main(string[] args)
    {
        static void BarraCarregamento(string textocarregamento){
        Console.WriteLine(textocarregamento);
        Thread.Sleep(500);

        for (var contador = 0; contador < 4; contador++){
        Console.Write(".");
        Thread.Sleep(500);
        }

        }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.Magenta;

        BarraCarregamento("Iniciando");
        Console.WriteLine(@$"
***************************************************************
*                                                             *
*               Bem vindo ao sistema de cadastro              *
*               de pessoa fisica e juridica                   *
*                                                             *
***************************************************************
        ");
        Thread.Sleep(1000);
        Console.Clear();
        string opcao;
do {
        Console.WriteLine(@$"
***************************************************************
*              Selecione uma das opções abaixo                *
***************************************************************
*               1 - Pessoa Fisica                             *
*               2 - Pessoa Juridica                           *
*                                                             *
*               0 - Sair                                      *
***************************************************************
        ");

        opcao = Console.ReadLine();

        switch (opcao){
            case "1":
         Endereco end = new Endereco();
         end.logradouro = "Rua X";
         end.numero = 100;
         end.complemento = "Proximo ao SENAI";
         end.enderecoComercial = false;

         PessoaFisica novaPessoa = new PessoaFisica();
         novaPessoa.nome = "Caique";
         novaPessoa.cpf = "45663175";
         novaPessoa.dataNascimento = new DateTime (2020, 05, 19);
         novaPessoa.endereco = end;

         
        Console.WriteLine($"{novaPessoa.nome} mora na {novaPessoa.endereco.logradouro} Nº {novaPessoa.endereco.numero}");

       bool idadeValidada = novaPessoa.ValidarDataNascimento(novaPessoa.dataNascimento);
       
       if (idadeValidada == true){
        Console.WriteLine("Cadastro Aprovado");
       }else{
        Console.WriteLine("Cadastro REPROVADO por motivos de idade");
       }
            break;
            case "2":
        Endereco endpj = new Endereco();
        endpj.logradouro = "Rua X";
        endpj.numero = 100;
        endpj.complemento = "Proximo ao SENAI";
        endpj.enderecoComercial = false;

        PessoaJuridica pj = new PessoaJuridica();
        pj.endereco = endpj;
        pj.cnpj = "12345678000001";
        pj.razaoSocial = "Bar do cleito";

            if (pj.ValidarCNPJ(pj.cnpj)){
            Console.WriteLine("CNPJ VALIDO");
        }else{
            Console.WriteLine("CNPJ INVALIDO");
        }
            break;
            case "0":
            Console.WriteLine("Obrigado por utilizar o nosso sistema");
            Console.WriteLine("Digite qualquer tecla para sair");
            Console.ReadLine();
            BarraCarregamento("Finalizando");
            break;
            default:
            Console.WriteLine("Opção invalida, por favor digite uma das opções apresentadas");
            break;
        }
    }while (opcao != "0");

        Console.ResetColor();
    }
}
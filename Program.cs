using FS19_UC12_Sistema.Classes;

class Program{
    static void Main(string[] args)
    {
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

        PessoaFisica Nathalia = new PessoaFisica();
        Nathalia.nome = "Nathalia Adena";

        PessoaFisica Pedro = new PessoaFisica();
        Pedro.nome = "Pedro Celestino";

        //Console.WriteLine(novaPessoa.nome);
        //Console.WriteLine(novaPessoa.cpf);
        //Console.WriteLine(novaPessoa.dataNascimento);
        //Console.WriteLine(novaPessoa.endereco.logradouro);
        //Console.WriteLine(novaPessoa.endereco.numero);
        //Console.WriteLine(novaPessoa.endereco.complemento);
        //Console.WriteLine(novaPessoa.endereco.enderecoComercial);

        //Concatenação
        //Console.WriteLine(novaPessoa.nome + " mora na " + novaPessoa.endereco.logradouro + " Nº " + novaPessoa.endereco.numero);

        //interpolação
        Console.WriteLine($"{novaPessoa.nome} mora na {novaPessoa.endereco.logradouro} Nº {novaPessoa.endereco.numero}");

       bool idadeValidada = novaPessoa.ValidarDataNascimento(novaPessoa.dataNascimento);
       
       if (idadeValidada == true){
        Console.WriteLine("Cadastro Aprovado");
       }else{
        Console.WriteLine("Cadastro REPROVADO por motivos de idade");
       }
    
    Console.WriteLine(Nathalia.nome);
    Console.WriteLine(Pedro.nome);
    }
}
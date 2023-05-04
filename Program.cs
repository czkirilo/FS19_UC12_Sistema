using FS19_UC12_Sistema.Classes;

class Program{
    static void Main(string[] args)
    {
        PessoaFisica novaPessoa = new PessoaFisica();
        novaPessoa.nome = "Caique";
        Console.WriteLine(novaPessoa.nome);
    }
}
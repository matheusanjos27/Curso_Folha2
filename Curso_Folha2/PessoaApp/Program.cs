using System;
using PessoaApp;

public class AppPessoa
{
    static void Main(string[] args)
    {
        PessoaCertidaoNascimento();
    }


    public static void PessoaCertidaoNascimento()
    {

        string nome;
        string strdata;
        string opcao;
        DateTime data;

        Pessoa pessoanome = new Pessoa();

        do
        {
            try
            {
                Console.Write("Nome:");
                nome = Console.ReadLine() ?? "";
                if (nome == "")
                {
                    Console.WriteLine("Nome invalido!");
                    continue;
                }
                pessoanome.AddPessoa(nome);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } while (true);

        Console.WriteLine("");
        Console.Write("Deseja adicionar uma certidao? (S/N)");
        opcao = Console.ReadLine()?.ToUpper() ?? "";
        if (opcao == "S")
        {
            do
            {
                try
                {
                    Console.Write("Data de nascimento (DD/MM/AAAA): ");
                    strdata = Console.ReadLine() ?? "";
                    if (!DateTime.TryParse(strdata, out data))
                    {
                        Console.WriteLine("Data informada invalida");
                        continue;
                    }
                    if (strdata == null)
                    {
                        Console.WriteLine("Data nao pode ser vazia");
                        continue;
                    }
                    CertidaoNascimento datacertidao = new CertidaoNascimento(data);

                    pessoanome.AddCertidao(datacertidao);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }

}







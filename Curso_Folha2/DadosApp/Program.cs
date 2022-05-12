using System;
using ValidacaoNS;

    static void Main(string[] args)
    {
       DadosApp.Dados();
    }

public class DadosApp
{


    public static void Dados()
    {

        //Variaveis de campo
        string? strnome = "";
        string? strcpf = "";
        string? strdatanasc = "";
        string? strrenda = "";
        string? strestadocivil = "";
        string? strdependentes = "";

        //ler nome
        strnome = LerNome();
        //ler  cpf
        strcpf = LerCpf();
        //ler data
        strdatanasc = LerData();
        //ler renda
        strrenda = LerRenda();
        //ler estado civil
        strestadocivil = LerEstadoCivil();
        //ler dependentes
        strdependentes = LerDependentes();

        ValidacaoNS.Validacao validacao = new ValidacaoNS.Validacao();

        DateTime data;


        if (!validacao.ValidaNome(strnome))
        {
            do
            {
                Console.WriteLine("Nome possui menos de 5 caracteres: " + strnome);
                strnome = LerNome();
            } while (!validacao.ValidaNome(strnome));
        }
        if (!validacao.ValidaCpf(strcpf))
        {
            do
            {
                Console.WriteLine("O Cpf precisa ter 11 digitos e ser válido: " + strcpf);
                strcpf = LerCpf();
            } while (!validacao.ValidaCpf(strcpf));
        }
        if (!validacao.ValidaData(strdatanasc))
        {
            do
            {
                Console.WriteLine("Data informada invalida, esta vazia ou cliente menor de 18 anos: " + strdatanasc);
                strdatanasc = LerData();
            } while (!validacao.ValidaData(strdatanasc));
        }
        if (!validacao.ValidaRenda(strrenda))
        {
            do
            {
                Console.WriteLine("Valor de renda invalido ou esta vazio: " + strrenda);
                strrenda = LerRenda();
            } while (!validacao.ValidaRenda(strrenda));
        }
        if (!validacao.ValidaEstadoCivil(strestadocivil))
        {
            do
            {
                Console.WriteLine("Estado Civil invalido ou esta vazio: " + strestadocivil);
                strestadocivil = LerEstadoCivil();
            } while (!validacao.ValidaEstadoCivil(strestadocivil));
        }
        if (!validacao.ValidaDependentes(strdependentes))
        {
            do
            {
                Console.WriteLine("Valor de dependentes invalido ou esta vazio: " + strdependentes);
                strdependentes = LerDependentes();
            } while (!validacao.ValidaDependentes(strdependentes));
        }

        //exibição
        DateTime.TryParse(strdatanasc, out data);

        Console.Clear();
        Console.WriteLine("Nome: " + strnome);
        Console.WriteLine("CPF: " + long.Parse(strcpf));
        Console.WriteLine("Data de nascimento: " + data.ToString("dd/MM/yyyy"));
        Console.WriteLine("Renda mensal: " + float.Parse(strrenda));
        Console.WriteLine("Estado civil: " + Convert.ToChar(strestadocivil));
        Console.WriteLine("Dependentes: " + Convert.ToInt16(strdependentes));
        Console.WriteLine("");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();

    }

    private static string? LerNome()
    {
        string? strnome;
        Console.Write("Insira seu nome: ");
        strnome = Console.ReadLine();
        return strnome;

    }

    private static string? LerCpf()
    {
        string? strcpf;
        Console.Write("Digite o cpf (11 digitos): ");
        strcpf = Console.ReadLine();
        return strcpf;
    }
    private static string? LerData()
    {
        string? strdatanasc;
        Console.Write("Digite a data de nascimento (DD/MM/AAAA) : ");
        strdatanasc = Console.ReadLine();
        return strdatanasc;
    }
    private static string? LerRenda()
    {
        string? strrenda;
        Console.Write("Digite sua renda: ");
        strrenda = Console.ReadLine();
        return strrenda;
    }
    private static string? LerEstadoCivil()
    {
        string? strestadocivil;
        Console.Write("Estado Civil ( C / S / V / D): ");
        strestadocivil = Console.ReadLine();
        return strestadocivil;
    }
    private static string? LerDependentes()
    {
        string? strdependentes;
        Console.Write("Digite o numero de dependentes (Entre 0 e 10): ");
        strdependentes = Console.ReadLine();
        return strdependentes;
    }
}
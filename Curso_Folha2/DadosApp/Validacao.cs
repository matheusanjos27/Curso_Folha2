using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoNS
{
    public class Validacao
    {
        private string nome;
        public string Nome { get { return nome; } }

        private string cpf;
        public string CPF { get { return cpf; } }

        private string datanasc;
        public string DataNascimento { get { return datanasc; } }

        private string renda;
        public string Renda { get { return renda; } }

        private string estadocivil;
        public string EstadoCivil { get { return estadocivil; } }

        private string dependentes;
        public string Dependentes { get { return dependentes; } }

        long xcpf = 0;
        DateTime xdata;
        float xrenda;
        char xestadocivil;
        int xdependentes;


        public Validacao() { }

        public bool ValidaNome(string validanome)
        {
            if (validanome != null && validanome != "" && validanome.Length >= 5)
            {
                return true;
            }
            return false;
        }
        public bool ValidaCpf(string validacpf)
        {
            if (!long.TryParse(validacpf, out xcpf) || validacpf == "" || validacpf.Length < 11 || validacpf.Length > 11)
            {
                return false;
            }
            else if (!VerificaCpf(validacpf))
            {
                return false;
            }
            return true;
        }
        public bool VerificaCpf(string validacpf)
        {
            int[] J = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] K = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            tempCpf = validacpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * J[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * K[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return validacpf.EndsWith(digito);

        }
        public bool ValidaData(string validadata)
        {
            DateTime hoje = DateTime.Now;
            if (!DateTime.TryParse(validadata, out xdata) || validadata == null || validadata == "" || (hoje.Year - xdata.Year) < 18)
            {
                return false;
            }
            return true;
        }
        public bool ValidaRenda(string validarenda)
        {
            if (!float.TryParse(validarenda, out xrenda) || validarenda == null || validarenda == "")
            {
                return false;
            }
            return true;
        }
        public bool ValidaEstadoCivil(string validaestadocivil)
        {
            if (validaestadocivil.Length > 1 ||
               (validaestadocivil.ToLower() != "c" &&
               validaestadocivil.ToLower() != "s" &&
               validaestadocivil.ToLower() != "v" &&
               validaestadocivil.ToLower() != "d") || validaestadocivil == null || validaestadocivil == "")
                return false;
            {
                return true;
            }
        }
        public bool ValidaDependentes(string validadependentes)
        {
            if (!int.TryParse(validadependentes, out xdependentes) || validadependentes == null || validadependentes == "" || Convert.ToInt16(validadependentes) < 0 || Convert.ToInt16(validadependentes) > 10)
            {
                return false;
            }
            return true;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrinhoDeComprasSRP.models
{
    public class EmailService
    {
        private string de = "contato@site.com.br";
        private string para;
        private string assunto;
        private string conteudo;
        public EmailService(string para,
        string assunto,
        string conteudo)
        {
            Para = para;
            Assunto = assunto;
            Conteudo = conteudo;
        }
        public static void DispararEmail()
        {
            Console.WriteLine("\nE-mail enviado!");
        }
        public string De
        {
            get { return de; }
            set { de = value; }
        }
        public string Para
        {
            get { return para; }
            set { para = value; }
        }
        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }
        public string Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }
    }
}
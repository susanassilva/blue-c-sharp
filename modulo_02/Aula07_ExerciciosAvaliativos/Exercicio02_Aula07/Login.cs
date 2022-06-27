using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Aula07
{
    public class Login
    {
        private string nomeUsuario;
        private string senhaUsuario;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string SenhaUsuario
        {
            get { return senhaUsuario; }
            set { senhaUsuario = value; }

        }

        public Login()
        {
            List<string> usuariosCadastrados = new List<string>();
            List<string> listaCadastrados = CriacaoConta(usuariosCadastrados);
        }

        private List<string> CriacaoConta(List<string> usuariosCadastrados)
        {
            Console.WriteLine("--Crie sua conta--");
            Console.WriteLine("Digite o nome de usuário:");
            Console.Write(">");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite a sua senha:");
            Console.Write(">");
            senhaUsuario = Console.ReadLine();

            usuariosCadastrados.Add(nomeUsuario + senhaUsuario);

            Console.WriteLine("Deseja entrar em sua conta?");
            Console.Write(">");
            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Entrar(usuariosCadastrados);
            }


            return usuariosCadastrados;

        }


        private void Entrar(List<string> usuariosCadastrados)
        {

            Console.WriteLine("Entre com o seu usuário: ");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("Entre com a sua senha: ");
            senhaUsuario = Console.ReadLine();


            foreach (var n in usuariosCadastrados)
            {
                if (n.Contains(senhaUsuario) && n.Contains(nomeUsuario))
                {
                    Console.WriteLine("Bem-vindo ao sistema");
                }
                else if (n.Contains(senhaUsuario) && (!n.Contains(nomeUsuario)))
                {
                    Console.WriteLine("Usuário não existe");
                }
                else if ((!n.Contains(senhaUsuario)) && (n.Contains(nomeUsuario)))
                {
                    Console.WriteLine("Senha inválida");
                }


            }

        }

    }
}
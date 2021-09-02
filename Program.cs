using System;

namespace Mentoria1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite a operação desejada:");
           Console.WriteLine("1 - Criar conta pessoal");
           Console.WriteLine("2 - Criar conta bancaria (nec.ContaPessoal)");
           Console.WriteLine("x - Sair");
           string opcaoUsuario = Console.ReadLine();

           while (opcaoUsuario.ToUpper() != "x")  
           {
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.Write("Digite o nome:");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o CPF:");
                        string cpf = Console.ReadLine();
                        Console.Write("Digite o RG:");
                        string rg = Console.ReadLine();
                        Console.WriteLine("Informe o endereço:");
                        Console.Write("Logradouro: ");
                        string logradouro = Console.ReadLine();
                        Console.Write("Cidade: ");
                        string cidade = Console.ReadLine();
                        Console.Write("Estado: ");
                        string estado = Console.ReadLine();
                        Console.Write("CEP: ");
                        string cep = Console.ReadLine();
                        Console.Write("Bairro: ");
                        string bairro = Console.ReadLine();

                        Endereco endereco = new Endereco(logradouro, cidade, estado, cep, bairro);

                        Cliente cliente = new Cliente(nome, cpf, rg, endereco);

                         break;

                    case "2":

                         break;

                    default:

                        throw new Exception("Valor não aceito!");

                }
           }

           
        }
    }
}

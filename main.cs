using System;

class Program {
  public static void Main (string[] args) 
  {
   
    string Empresa;
    string CNPJ;
    string CEP;
    string logradouro;
    string bairro;
    string numero;
    string complemento;
    
    Console.WriteLine ("Digite o nome da sua Empresa: ");
    Empresa = Console.ReadLine();

    Console.WriteLine("Digite o CNPJ de sua Empresa: ");
    CNPJ = Console.ReadLine();

    Console.WriteLine("Digite o CEP da sua Empresa");
    CEP = Console.ReadLine();
    
    Console.WriteLine ("Digite seu logradouro: ");
    logradouro = Console.ReadLine();

    Console.WriteLine("Digite o bairro onde fica sua Empresa: ");
    bairro = Console.ReadLine();

        Console.WriteLine("Digite o numero de sua Empresa: ");
        numero = Console.ReadLine();

        Console.WriteLine("Digite um Complemento (opcional)");
        complemento = Console.ReadLine();
    
    }
  }
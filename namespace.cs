using System;
namespace Teste
{
    class Program
    {
      static void main(String [] args)
      {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        if(a==0 || b == 0)
        {
          Console.WriteLine("Não é possivel dividir");
        }else
        {
          var divisao = a / b;
          console.WriteLine($"O resultado da divisão é: {divisao}");
        }
      }
    }
}
using System;

namespace aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
             CartaoCredito visa = new CartaoCredito();
             visa.titular = "Beatriz";
             visa.limite = 2000;
            

        System.Console.WriteLine("Digite a data do pagamento");
        visa.data = DateTime.Parse( Console.ReadLine());
        Console.WriteLine("Data digitada: "+visa.data);

        
        Console.WriteLine("Digite acrescimo desejado");
        float acrescimo = float.Parse(Console.ReadLine());
        visa.AumentarLimite(acrescimo);
        Console.WriteLine("novo limite: "+visa.limite);


        }
    }
}

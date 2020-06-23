using System;

namespace Aula22MetodosEAtributosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine( Conversor.ConverterDolarReal(23) );
            System.Console.WriteLine( Conversor.ConverterRealDolar(122) );

            System.Console.WriteLine( Conversor.ConverterEuroReal(23) );
            System.Console.WriteLine( Conversor.ConverterRealEuro(137) );
        }
    }
}

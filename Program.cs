using System;

namespace ExercicioDecrementoNumerosRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMaximo;
            int contadorExterno = 0;
            int contadorInterno = 1;

            Console.WriteLine("Digite o numero inicial da contage: ");
            valorMaximo = Convert.ToInt32(Console.ReadLine());

            while (contadorExterno < valorMaximo)
            {   
                Console.WriteLine();
                while(contadorInterno <= valorMaximo - contadorExterno)
                {
                Console.Write(contadorInterno + " ");
                contadorInterno = contadorInterno + 1;
                }
                contadorExterno = contadorExterno + 1;
                contadorInterno = 1;
            }
        }
    }
}

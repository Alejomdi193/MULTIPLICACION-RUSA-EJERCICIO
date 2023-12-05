namespace Ejercicio3
{
    class Class{
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("multiplicacion rusa");
            Console.Write("\n");

            Console.Write("\nIngrese el numero multiplicador: ");
            int cador = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el numero multiplicando: ");
            int cando = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;
            while(cador >= 1)
            {
                
                if(cador%2 != 0 )
                {
                    resultado += cando;

                }
            cador /= 2;
            cando *= 2;
            }
            
            Console.WriteLine($"El resultado es {resultado}");
        }
    }
}
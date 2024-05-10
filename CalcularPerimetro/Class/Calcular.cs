
namespace CalcularPerimetro.Class
{
    public class Calcular
    {
        public void CalcularPerimetro() 
        {
            decimal lado = 0;
            decimal perimetro = 0;

            try
            {
                Console.WriteLine("Ingrese la longitud de uno de los lados del cuadrado: ");
                lado = decimal.Parse(Console.ReadLine());

                perimetro = (lado * 4);

                Console.WriteLine($"El perimetro de el cuadrado es: { perimetro} ");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrio el siguiente error: { ex.Message } ");
            }

           

        }
    }
}

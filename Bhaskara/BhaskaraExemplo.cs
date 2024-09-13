
namespace BhaskaraExemplo
{
    public class BhaskaraExemplo
    {
            public static (double, double) CalcularRaizes(double a, double b, double c)
            {
                // Calcula o discriminante
                double delta = b * b - 4 * a * c;

                // Verifica se o discriminante é positivo
                if (delta > 0)
                {
                    // Calcula as raízes reais
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    // Retorna as raízes em ordem crescente
                    return x1 < x2 ? (x1, x2) : (x2, x1);
                }
                else
                {
                    // Lança uma exceção se o discriminante for não-positivo
                    throw new InvalidOperationException("A equação não tem raízes reais.");
                }
            }
            /* public static (double, double) CalcularRaizes(double a, double b, double c)
             {
                 double delta = b * b - 4 * a * c;

                if (delta < 0)
                 {
                     throw new InvalidOperationException("Não há raízes reais.");
                 }

                 double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                 double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                 return (x1, x2);
             }*/
        }
    }



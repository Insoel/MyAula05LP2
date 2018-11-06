using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insere um numero inteiro: ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não foi inserido um numero inteiro");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Foi inserido um numero demasiado grande");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Mensagem descodificada, programa vai-se autodestruir em 10 segundos.");
            }


        }
    }
}

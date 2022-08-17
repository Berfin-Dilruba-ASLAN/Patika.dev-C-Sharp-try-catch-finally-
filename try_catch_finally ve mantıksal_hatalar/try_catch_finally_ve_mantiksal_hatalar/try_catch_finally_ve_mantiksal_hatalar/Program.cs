using System;

namespace try_catch_finally_ve_mantiksal_hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("HATA: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı. ");
            }
        }
    }
}


using System;
using System.Threading;

namespace ServiceTest
{
    class Program
    {
        public static DBApplication app;

        static void Main(string[] args)
        {
            app = new DBApplication();
            Console.WriteLine("Iniciando APPService");
            try
            {
                app.Run();
            }catch(Exception e)
            {
                Console.WriteLine("##### ERRORES #####");
                Console.WriteLine("Error: "+e.Message+" ##### En el objeto: "+e.Source);
                Console.WriteLine("##### ERRORES #####");
            }
            Console.ReadKey();
            Console.WriteLine("Cerrando APPService");
            app.Shutdown();
        }
    }
}

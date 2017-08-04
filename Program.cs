using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingByConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register error handler
            System.Threading.Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(Program_UnhandledException);

            throw new Exception("Error");
        }

        public static void Program_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            // Write StackTrace and errors
        }
    }
}

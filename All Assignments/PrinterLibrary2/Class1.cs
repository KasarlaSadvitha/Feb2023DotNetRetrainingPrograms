public delegate void PrintDelegate();
namespace PrinterLibrary2
{
   
    public class Printer
    {
        public static void Print(PrintDelegate p)
        {
           p();
        }
    }
}
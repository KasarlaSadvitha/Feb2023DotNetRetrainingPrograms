
namespace PrinterLibrary
{
    public  delegate void PrintDelegate();
    public class Printer
    {
        public static void Print(PrintDelegate p)
        {
           p();
        }
    }

}
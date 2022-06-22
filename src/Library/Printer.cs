namespace Poker
{
    public static class Printer
    {
        public static void Print(List<Carta> lista)
        {
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(item.Descripcion);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
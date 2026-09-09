namespace ChessBoard;
//◼︎
//◻︎
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Multiplikationstabell 1-5:");
        Console.Write("Ange storleken på schakbrädet: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Ange den första symbolen för schakbrädet: ");
        string white = Console.ReadLine();
        Console.WriteLine("Ange den andra symbolen för schackbrädet: ");
        string black = Console.ReadLine();
        Console.WriteLine();
        
        for (int row = 1; row <= width; row++)
        {
            for (int column = 1; column <= width; column++)
                if ((row + column) %2 == 0)
                {
                    Console.Write(white);
                }
                else
                {
                    Console.Write(black);
                }
            Console.WriteLine();
        }
            
    }
}
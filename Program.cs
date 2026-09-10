namespace ChessBoard;
//◼︎
//◻︎
class Program
{
    static void Main(string[] args)
    {
        // Ask the user for size and alternating symbols before creating a chessboard pattern
        Console.WriteLine("ChessBoard 2.0");
        Console.Write("Ange storleken på schakbrädet: ");
        
        // This is the size of the chessboard, how many times we run the loop
        int width = int.Parse(Console.ReadLine());

        Console.Write("Ange den första symbolen för schakbrädet: ");
        // This is the first symbol for the chessboard, the white square
        string white = Console.ReadLine();

        Console.Write("Ange den andra symbolen för schackbrädet: ");
        // This is the second symbol for the chessboard, the black square
        string black = Console.ReadLine();

        Console.Write("Ange ruta för din pjäs med kolumn,rad (t.ex. E5): ");
        // This is the position of the piece on the chessboard, in the format "row,column"
        string queenPosit = Console.ReadLine().ToUpper();

        Console.Write("Ange symbolen för din pjäs: ");
        string queenSymbol = Console.ReadLine();

        Console.WriteLine();

        // This is the loop that creates the chessboard pattern
        // for each row, we loop through enough columns to match the width
        // and we loop enough rows to match the width as well
        for (int row = 1; row <= width; row++)
        {
                // Loop for the columns
            for (int column = 1; column <= width; column++)
                // Check if the current position matches the queenPosit
                // We treat the first character of the queenPosit as a column (A=1, B=2, etc.) and the second character as a row (1-9)
                // By using [0] and [1] we can get the characters from the string and convert them to ints
                // We subtract '0' (48) from the row character, and 'A' (65) from the column character to get regular numbers
                // We add 1 to the column character so A = 1 when we loop through the columns
                // which gives us the correct number of times we need to run the loop before we print the queenSymbol
                if ( row == queenPosit[1] - '0' && column == queenPosit[0] - 'A' + 1)
                {
                    // Print the queenSymbol if it matches
                    Console.Write(queenSymbol + " ");
                }
                // If it doesn't match, check if the sum of the row and column is even
                else if ((row + column) %2 == 0)
                {
                    // Print the white symbol if the sum is even
                    Console.Write(white + " ");
                }
                else
                {
                    // Print the black symbol if the sum is odd
                    Console.Write(black + " ");
                }
            Console.WriteLine();
        }
            
    }
}
GenerateButtons();

//macOS
static void GenerateButtons()
{
    string[,] buttons = new string[8, 8];

    for (int i = 0; i <= buttons.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= buttons.GetUpperBound(1); j++)
        {
            buttons[i, j] = j.ToString();

            if ((i + j) % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Write("| {0} |", buttons[i, j]);
        }
        Console.WriteLine();
    }
}
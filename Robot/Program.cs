using System;
using DisplayHelper;

namespace Robot
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Display displayGreet = new Display("Jaké je vaše přání?", 6, 3);
            displayGreet.AddItem(new LabelItem("[A] Vrtání"));
            displayGreet.AddItem(new LabelItem("[B] Přesun"));
            displayGreet.AddItem(new LabelItem("[C] Řezání"));
            Display displayChange = new Display("Chceš změnit činnost? [Y]", 33, 20);
            Display displayContinue = new Display("Dokončeno. Chceš pokračovat ve stávající činnosti? [Y]", 33, 20);
            Display displayEnd = new Display("Ukončuji proces.", 6, 3);
            displayEnd.AddItem(new LabelItem(""));
            ConsoleKeyInfo result;
            displayGreet.Refresh();
            result = Console.ReadKey();
            while (result.Key == ConsoleKey.A || result.Key == ConsoleKey.B || result.Key == ConsoleKey.C)
            {
                if (result.Key == ConsoleKey.A)
                {
                    do
                    {
                        Console.Clear();
                        displayContinue.Refresh();
                        result = Console.ReadKey();
                    } while (result.Key == ConsoleKey.Y || result.Key == ConsoleKey.Enter);
                    Console.Clear();
                    displayChange.Refresh();
                    result = Console.ReadKey();
                    if (result.Key == ConsoleKey.Y || result.Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (result.Key == ConsoleKey.B)
                {
                    do
                    {
                        Console.Clear();
                        displayContinue.Refresh();
                        result = Console.ReadKey();
                    } while (result.Key == ConsoleKey.Y || result.Key == ConsoleKey.Enter);
                    Console.Clear();
                    displayChange.Refresh();
                    result = Console.ReadKey();
                    if (result.Key != ConsoleKey.Y || result.Key != ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (result.Key == ConsoleKey.C)
                {
                    do
                    {
                        Console.Clear();
                        displayContinue.Refresh();
                        result = Console.ReadKey();
                    } while (result.Key == ConsoleKey.Y || result.Key == ConsoleKey.Enter);
                    Console.Clear();
                    displayChange.Refresh();
                    result = Console.ReadKey();
                    if (result.Key != ConsoleKey.Y || result.Key != ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            displayEnd.Refresh();
            Console.ReadKey();
        }
    }
}

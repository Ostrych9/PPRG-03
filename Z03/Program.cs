

// Zadanie 3


Console.WriteLine("Ile masz lat?");
int wiek = int.Parse(Console.ReadLine()!);

 if (wiek < 0)
        {
            Console.WriteLine("Niepoprawny wiek.");
        }
    else if (wiek <= 12)
        {
            Console.WriteLine("Dziecko.");
        }
    else if (wiek <= 17)
        {
            Console.WriteLine("Nastolatek.");
        }
    else if (wiek <= 64)
        {
            Console.WriteLine("Osoba dorosła.");
        }
    else
        {
            Console.WriteLine("Senior.");
        }
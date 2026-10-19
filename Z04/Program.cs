 
 
 // Zadanie 4
 
 
 Console.Write("Podaj punkty życia: ");
int zycie = int.Parse(Console.ReadLine()!);

Console.Write("Czy masz klucz? (true/false): ");
bool klucz = bool.Parse(Console.ReadLine()!);

Console.Write("Czy znasz hasło? (true/false): ");
bool haslo = bool.Parse(Console.ReadLine()!);

if (zycie <= 0)
    {
        Console.WriteLine("Bohater nie może wejść, ponieważ nie żyje.");
    }
else if (zycie > 0 && (klucz || haslo))
    {
        Console.WriteLine("Bohater może wejść do lochu.");
    }
else
    {
        Console.WriteLine("Bohater nie może wejść, ponieważ nie przejdzie przez drzwi.");
    }



// Zadanie 05


Console.Write("Podaj punkty życia: ");
int zycie = int.Parse(Console.ReadLine()!);

Console.Write("Podaj obrażenia broni: ");
int obrazenia = int.Parse(Console.ReadLine()!);

Console.Write("Czy masz miksturę? (true/false): ");
bool mikstura = bool.Parse(Console.ReadLine()!);

Console.Write("Wybierz akcję: \n1-atak \n2-leczenie \n3-ucieczka \n");
int akcja = int.Parse(Console.ReadLine()!);

if (zycie <= 0)
{
    Console.WriteLine("Przegrałeś! Bohater nie żyje.");
}
else
{
    switch (akcja)
    {
        case 1:
            Console.WriteLine("Zadajesz " + obrazenia + " obrażeń.");
            break;

        case 2:
            if (mikstura)
            {
                Console.WriteLine("Bohater używa mikstury i się leczy.");
                zycie += zycie + 20;
            }
            else
            {
                Console.WriteLine("Nie masz mikstury!");
            }
            break;

        case 3:
            Console.WriteLine("Bohater ucieka z walki.");
            break;

        default:
            Console.WriteLine("Nieznana akcja.");
            break;
    }
    
    if (zycie < 20)
    {
        Console.WriteLine("Uwaga! Masz mało punktów życia!");
    }
}
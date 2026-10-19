

// Zadanie 6 - Projekt


Console.Write("Podaj imię bohatera: ");
string imie = Console.ReadLine()!;

Console.Write("Podaj punkty życia: ");
int zycie = int.Parse(Console.ReadLine()!);

Console.Write("Podaj poziom bohatera: ");
int poziom = int.Parse(Console.ReadLine()!);

Console.Write("Podaj ilość złota: ");
int zloto = int.Parse(Console.ReadLine()!);

Console.Write("Podaj siłę bohatera: ");
int sila = int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę mikstur: ");
int mikstury = int.Parse(Console.ReadLine()!);

Console.Write("Czy masz mapę? (true/false): ");
bool mapa = bool.Parse(Console.ReadLine()!);

Console.Write("Czy masz kompas? (true/false): ");
bool kompas = bool.Parse(Console.ReadLine()!);


bool zyje = zycie > 0;
bool niskieZdrowie = zyje && zycie < 25;
bool mozeWyruszyc = zyje && (mapa || kompas);
bool bogaty = zloto >= 100;
bool gotowyDoWalki = zyje && mikstury >= 1;


string statusWyprawy = mozeWyruszyc ? "TAK" : "NIE";
string statusWalki = gotowyDoWalki ? "TAK" : "NIE";
string statusBogactwa = bogaty ? "TAK" : "NIE";


Console.WriteLine();

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("===== STATUS BOHATERA =====");
Console.ResetColor();

Console.WriteLine("Bohater: " + imie);
Console.WriteLine("Poziom: " + poziom);
Console.WriteLine("Siła: " + sila);

Console.Write("Zdrowie: ");
if (zycie <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
}
else if (zycie < 25)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
}
Console.WriteLine(zycie);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Mikstury: " + mikstury);
Console.WriteLine("Złoto: " + zloto);
Console.WriteLine("Mapa: " + mapa);
Console.WriteLine("Kompas: " + kompas);
Console.ResetColor();

Console.WriteLine();
Console.WriteLine("===== INFORMACJE =====");
Console.WriteLine("Żyje: " + zyje);
Console.WriteLine("Niskie zdrowie: " + niskieZdrowie);
Console.WriteLine("Bogaty: " + statusBogactwa);
Console.WriteLine("Gotowy do walki: " + statusWalki);

Console.Write("Gotowy do wyprawy: ");
Console.ForegroundColor = mozeWyruszyc ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine(statusWyprawy);
Console.ResetColor();

Console.WriteLine();

// Opis stanu bohatera
if (!zyje)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie żyje.");
    Console.ResetColor();
}
else if (niskieZdrowie)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Bohater jest ranny.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Bohater jest w dobrej formie.");
    Console.ResetColor();
}

// Menu akcji
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("===== MENU AKCJI =====");
Console.ResetColor();

Console.WriteLine("1. Sprawdź stan");
Console.WriteLine("2. Rozpocznij wyprawę");
Console.WriteLine("3. Przygotuj miksturę");
Console.WriteLine("4. Odpocznij");

Console.Write("Wybierz akcję: ");
int akcja = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (!zyje)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nie możesz wykonać akcji, ponieważ bohater nie żyje.");
    Console.ResetColor();
}
else
{
    switch (akcja)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sprawdzasz stan bohatera.");
            Console.WriteLine("Życie: " + zycie);
            Console.WriteLine("Poziom: " + poziom);
            Console.WriteLine("Siła: " + sila);
            Console.ResetColor();
            break;

        case 2:
            if (mozeWyruszyc)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(imie + " rozpoczyna wyprawę!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie możesz wyruszyć! Nie masz mapy ani kompasu.");
                Console.ResetColor();
            }
            break;

        case 3:
            if (mikstury > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bohater przygotowuje miksturę.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz żadnej mikstury!");
                Console.ResetColor();
            }
            break;

        case 4:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bohater odpoczywa i odzyskuje siły.");
            Console.ResetColor();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nieznana akcja.");
            Console.ResetColor();
            break;
    }
}

Console.WriteLine();
Console.WriteLine("===== KONIEC RAPORTU =====");

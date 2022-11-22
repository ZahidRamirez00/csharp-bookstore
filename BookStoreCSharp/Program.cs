// See https://aka.ms/new-console-template for more information

string titoloLibro = "";
string autoreLibro = "";
string isbnLibro = "";
int numeroPagineLibro = 0;
float pesoLibro = 0;
float larghezzaLibro = 0;
float altezzaLibro = 0;
float profonditaLibro = 0;
float valutazioneMediaLibro = 0;
int numeroRecenzioniLibro = 0;
bool versioneKindle = false;
bool copertinaFlessibile = false;
char ynConsole = '';


titoloLibro = Console.ReadLine("Inserisci il titolo del libro: ");
autoreLibro = Console.ReadLine("Inserisci l'autire del libro: ");
isbnLibro = Console.ReadLine("Inserisci ISBN del libro: ");
numeroPagineLibro = int.Parse(Console.ReadLine("Inserisci il numero di pagine del libro: ");
pesoLibro = float.Parse(Console.ReadLine("Inserisci il peso del libro (in Kg): "));
larghezzaLibro = float.Parse(Console.ReadLine("Inserisci la larghezza del libro (in cm): "));
altezzaLibro = float.Parse(Console.ReadLine("Inserisci l'altezza del libro (in cm): "));
profonditaLibro = float.Parse(Console.ReadLine("Inserisci la profondità del libro (in cm): "));
valutazioneMediaLibro = float.Parse(Console.ReadLine("Inserisci la valutazione media del libro: "));
numeroPagineLibro = int.Parse(Console.ReadLine("Inserisci il numero di recensioni del libro: ");

do {
    ynConsole = Console.ReadLine("Inserisci se è disponibile in versione Kindle (y/n): ");
    if (ynConsole == 'y')
    {
        versioneKindle = true;
    }
    else if{
        versioneKindle = false;
    }
    else
    {
        Console.Write("Hai inserito un valore sbagliato, inserisci (y) o (n).")
    }

}while(ynConsole == 'y' || ynConsole == 'n');

ynConsole = '';

do
{
    ynConsole = Console.ReadLine("Inserisci se la copertina flessibile è disponibile (y/n): ");
    if (ynConsole == 'y')
    {
        copertinaFlessibile = true;
    }
    else if{
        copertinaFlessibile = false;
    }
    else
    {
        Console.Write("Hai inserito un valore sbagliato, inserisci (y) o (n).")
    }

} while (ynConsole == 'y' || ynConsole == 'n');



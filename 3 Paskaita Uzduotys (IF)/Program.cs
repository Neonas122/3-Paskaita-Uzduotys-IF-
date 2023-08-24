using System.Collections.Specialized;
using System.Xml;

Console.WriteLine("1 Uzduotis");

Console.WriteLine("Iveskite skaiciu:");
string stringnumber = Console.ReadLine();
int number = Convert.ToInt32(stringnumber);
if (number > 100) Console.WriteLine("Didesnis uz 100");
else if (number < 100) Console.WriteLine("Mazesnis uz 100");
else Console.WriteLine("lygus 100");

Console.WriteLine("");
Console.WriteLine("2 Uzduotis");

Console.WriteLine("Iveskite dienos numeri:");
string stringdaynumber = Console.ReadLine();
int daynumber = Convert.ToInt32(stringdaynumber);
if (daynumber == 1) Console.WriteLine("pirmadienis");
else if (daynumber == 2) Console.WriteLine("antradienis");
else if (daynumber == 3) Console.WriteLine("treciadienis");
else if (daynumber == 4) Console.WriteLine("ketvirtadienis");
else if (daynumber == 5) Console.WriteLine("penktadienis");
else if (daynumber == 6) Console.WriteLine("sestadienis");
else if (daynumber == 7) Console.WriteLine("sekmadienis");

Console.WriteLine("");
Console.WriteLine("3 Uzduotis");

Console.WriteLine("Iveskite skaiciu:");
string stringnr = Console.ReadLine();
int nr = Convert.ToInt32(stringnr);
if ((nr % 5 == 0) && (nr % 2 == 0))
{
    Console.WriteLine("Skaicius Dalinasi is 5");
    Console.WriteLine("Skaicius Lyginis");
}
else if (nr % 5 == 0) Console.WriteLine("Skaicius Dalinasi is 5");
else if (nr % 2 == 0) Console.WriteLine("Skaicius Lyginis");
else Console.WriteLine("Skaicius neatitinka jokiu salygu");

Console.WriteLine("");
Console.WriteLine("4 Uzduotis");

Console.WriteLine("Iveskite temperatura:");
string stringtemperature = Console.ReadLine();
int temperature = Convert.ToInt32(stringtemperature);
if ((temperature > 0) && (temperature < 20)) Console.WriteLine("vesu");
else if (temperature <= 0) Console.WriteLine("salta");
else Console.WriteLine("karsta");

Console.WriteLine("");
Console.WriteLine("5 Uzduotis");

Console.WriteLine("Iveskite laika kada atsikelete:");
string stringtime = Console.ReadLine();
int time = Convert.ToInt32(stringtime);
while ((time < 0) || (time > 24))
{
    Console.WriteLine("Ivestas blogas laikas");
    Console.WriteLine("Iveskite laika kada atsikelete:");
    stringtime = Console.ReadLine();
    time = Convert.ToInt32(stringtime);
}
if (time < 12) Console.WriteLine("Geros dienos!");
else if (time < 18) Console.WriteLine("Geros popietes!");
else Console.WriteLine("Gero vakaro!");

Console.WriteLine("");
Console.WriteLine("6 Uzduotis");

Console.WriteLine("Sugalvokite slaptazodi:");
string Password = Console.ReadLine();
int tries = 5;
if (Password == "Mellon") Console.WriteLine("Sekmingai prisijungete!");
else if (Password == "01101001 01101110") Console.WriteLine("Nulauzta...");
else
{
    Console.WriteLine("Iveskite slaptazodi:");
    string CheckPassword = Console.ReadLine();
    if (Password == CheckPassword) Console.WriteLine("Sekmingai prisijungete!");
    else
    {
        while (tries > 0)
        {
            Console.WriteLine("Blogas slaptazodis, liko " + tries + " bandymu");
            Console.WriteLine("Iveskite slaptazodi:");
            CheckPassword = Console.ReadLine();
            tries--;
            if (CheckPassword == "Mellon")
            {
                Console.WriteLine("Sekmingai prisijungete!");
                break;
            }

            else if (CheckPassword == "01101001 01101110")
            {
                Console.WriteLine("Nulauzta...");
                break;
            }
            else if (Password == CheckPassword)
            {
                Console.WriteLine("Sekmingai prisijungete!");
                break;
            }
            if (tries == 0) Console.WriteLine("Uzblokuota");
        }
    }


}
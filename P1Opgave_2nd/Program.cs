


// C# OPGAVER TIL P1 PROGRAMMØR //


// STANDARD NAMESPACESS

using System;
using System.Threading;
using System.Linq;

namespace P1opgaver // mit namespace
{
    class Program // mit klass
    {
        // Main metod (indgangspunktet for en eksekverbar program hvor program starter og slutter)

        static void Main(string[] args) // main, programmets indgangspunkt 
        {
            HovedMenu();       // programmet starter med hoved menu
            Console.ReadKey();  // programmet venter på et tastetryk

        }

        // HOVEDMENU med alle emnerne

        static void HovedMenu()
        {

            string valg; // string erklært
            Console.Clear(); // ren konsole vindue
            Console.SetCursorPosition(2, 4); // indstilling af x-akse og y-akse
            Console.ForegroundColor = ConsoleColor.Red; // foregroundcolor sættes til rød
            Console.WriteLine("                                         C# Opgaver til P1 programmør             ");
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Alle opgæverne.");

            Console.WriteLine(string.Empty); // giver et space i cmd'n

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("[1] Variabler ");
            Console.WriteLine("[2] Strings   ");
            Console.WriteLine("[3] Aritmetiske udtryk ");
            Console.WriteLine("[4] Variabler i udtryk ");
            Console.WriteLine("[5] Boolske variable ");
            Console.WriteLine("[6] If-else statements ");
            Console.WriteLine("[7] Switch Case ");
            Console.WriteLine("[8] Loops ");
            Console.WriteLine("[9] Udvide kontrolstrukturer ");
            Console.WriteLine("[10] Arrays");
            Console.WriteLine("[11] Afslut programmet!!");

            Console.WriteLine(string.Empty); // giver et space i cmd'n
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Vælg et emne");

            valg = Console.ReadLine(); // det læser hvad brugeren indtaster
            valg.ToLower();


            switch (valg) // switch case menu som er hoved menu
            {
                case "1": // stedet hvor alle de små menuer skal være
                    Console.Clear(); // det gør cmd'n ren for kode der kan været brugt fra før
                    VariablerSubMenu();
                    break; // afslutter case

                case "2":
                    Console.Clear();
                    StringsSubMenu();
                    break;


                case "3":
                    Console.Clear();
                    AritmetiskeUdtryk();
                    break;

                case "4":
                    Console.Clear();
                    VariableriUdtrykSubMenu();
                    break;

                case "5":
                    Console.Clear();
                    BoolskeVariable();
                    break;

                case "6":
                    Console.Clear();
                    IfElseStatementsSubMenu();
                    break;

                case "7":
                    Console.Clear();
                    SwitchCaseSubMenu();
                    break;

                case "8":
                    Console.Clear();
                    LoopSubMenu();
                    break;

                case "9":
                    Console.Clear();
                    UdvidetKontrolstrukturerSubMenu();
                    break;

                case "10":
                    Console.Clear();
                    ArraySubMenu();
                    break;

                case "11":
                    Console.Clear();
                    Console.WriteLine(" Du afsluttede programmet.");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(" Du har valgt forkert");
                    Thread.Sleep(1000); // delay 
                    HovedMenu();
                    break;
            }
        }


        // UNDERMENU med opgaverne

        static void VariablerSubMenu() // lille menu altså opgaverne for emnet variabler


        {
            string valg;

            do

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             '' VARIABLER ''       ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);
                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] Opgave 3");
                Console.WriteLine("  [4] Opgave 4");
                Console.WriteLine("  [5] Opgave 5");
                Console.WriteLine("  [6] Opgave 6");
                Console.WriteLine("  [7] For at komme tilbage til den Hovedmenu");

                valg = Console.ReadLine(); // det læser hvad brugerne indtaste

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        Variable1(); // metod til opgave 1 af variabler
                        break;

                    case "2":
                        Console.Clear();
                        Variable2();
                        break;


                    case "3":
                        Console.Clear();
                        Variable3();
                        break;

                    case "4":
                        Console.Clear();
                        Variable4();
                        break;

                    case "5":
                        Console.Clear();
                        Variable5();
                        break;

                    case "6":
                        Console.Clear();
                        Variable6();
                        break;

                    case "7":
                        Console.Clear();
                        HovedMenu();
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;
                }

            }
            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5" && valg != "6" && valg != "7");

        }

        static void StringsSubMenu()

        {
            string valg;

            do

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             '' STRING ''       ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] Opgave 3");
                Console.WriteLine("  [4] Opgave 4");
                Console.WriteLine("  [5] For at komme tilbage til den Hovedmenu");

                valg = Console.ReadLine();


                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        String1();
                        break;

                    case "2":
                        Console.Clear();
                        String2();
                        break;

                    case "3":
                        Console.Clear();
                        String3();
                        break;

                    case "4":
                        Console.Clear();
                        String4();
                        break;

                    case "5":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;
                }

            }
            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5");

        }

        static void VariableriUdtrykSubMenu()
        {
            string valg;

            do
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             ''  VARIABLER I UDTRYK  ''    ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] For at komme tilbage til den Hovedmenu");

                valg = Console.ReadLine();



                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        VariableriUdtryk1();
                        break;

                    case "2":
                        Console.Clear();
                        VariableriUdtryk2();
                        break;

                    case "3":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;
                }

            }

            while (valg != "1" && valg != "2" && valg != "3");


        }

        static void IfElseStatementsSubMenu()
        {

            string valg;

            do

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             ''  IF ELSE STATEMENTS  ''    ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] Opgave 3");
                Console.WriteLine("  [4] Opgave 4");
                Console.WriteLine("  [5] Opgave 5");
                Console.WriteLine("  [6] Opgave 6");
                Console.WriteLine("  [7] Opgave 7");
                Console.WriteLine("  [8] For at komme tilbage til den Hovedmenu");
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        IfElseStatement1();
                        break;

                    case "2":
                        Console.Clear();
                        IfElseStatement2();
                        break;


                    case "3":
                        Console.Clear();
                        IfElseStatement3();
                        break;

                    case "4":
                        Console.Clear();
                        IfElseStatement4();
                        break;

                    case "5":
                        Console.Clear();
                        IfElseStatement5();
                        break;

                    case "6":
                        Console.Clear();
                        IfElseStatement6();
                        break;

                    case "7":
                        Console.Clear();
                        IfElseStatement7();
                        break;

                    case "8":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;

                }

            }
            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "6" && valg != "7" && valg != "8");

        }

        static void SwitchCaseSubMenu()
        {

            string valg;

            do

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             ''  SWITCH CASE  ''    ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] For at komme tilbage til den Hovedmenu");
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        SwitchCase1();
                        break;

                    case "2":
                        Console.Clear();
                        SwitchCase2();
                        break;

                    case "3":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;

                }
            }

            while (valg != "1" && valg != "2" && valg != "3");
        }

        static void LoopSubMenu()
        {
            string valg;

            do

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             ''  LOOP  ''    ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] Opgave 3");
                Console.WriteLine("  [4] Opgave 4");
                Console.WriteLine("  [5] Opgave 5");
                Console.WriteLine("  [6] Opgave 6");
                Console.WriteLine("  [7] Opgave 7");
                Console.WriteLine("  [8] Opgave 8");
                Console.WriteLine("  [9] Opgave 9");
                Console.WriteLine("  [10] For at komme tilbage til den Hovedmenu");
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        Loop1();
                        break;

                    case "2":
                        Console.Clear();
                        Loop2();
                        break;


                    case "3":
                        Console.Clear();
                        Loop3();
                        break;

                    case "4":
                        Console.Clear();
                        Loop4();
                        break;

                    case "5":
                        Console.Clear();
                        Loop5();
                        break;

                    case "6":
                        Console.Clear();
                        Loop6();
                        break;

                    case "7":
                        Console.Clear();
                        Loop7();
                        break;

                    case "8":
                        Console.Clear();
                        Loop8();
                        break;

                    case "9":
                        Console.Clear();
                        Loop9();
                        break;

                    case "10":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;

                }

            }
            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5" && valg != "6" && valg != "7" && valg != "8" && valg != "9" && valg != "10");

        }

        static void UdvidetKontrolstrukturerSubMenu()

        {
            string valg;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             ''  UDVIDET KONTROL STRUKTURE  ''    ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] Opgave 3");
                Console.WriteLine("  [4] Opgave 4");
                Console.WriteLine("  [5] Opgave 5");
                Console.WriteLine("  [6] For at komme tilbage til den Hovedmenu");
                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        UdvidetKontrolstrukturer1();
                        break;

                    case "2":
                        Console.Clear();
                        UdvidetKontrolstrukturer2();
                        break;


                    case "3":
                        Console.Clear();
                        UdvidetKontrolstrukturer3();
                        break;

                    case "4":
                        Console.Clear();
                        UdvidetKontrolstrukturer4();
                        break;

                    case "5":
                        Console.Clear();
                        UdvidetKontrolstrukturer5();
                        break;

                    case "6":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;
                }

            }
            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5" && valg != "6");

        }

        static void ArraySubMenu()

        {
            string valg;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(string.Empty);
                Console.WriteLine("                                             ''  ARRAY ''    ");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en opgave");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(string.Empty);

                Console.WriteLine("  [1] Opgave 1");
                Console.WriteLine("  [2] Opgave 2");
                Console.WriteLine("  [3] For at komme tilbage til den Hovedmenu");

                valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.Clear();
                        Array1();
                        break;

                    case "2":
                        Console.Clear();
                        Array2();
                        break;

                    case "3":
                        Console.Clear();
                        HovedMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Du har valgt forkert");
                        Thread.Sleep(1000);
                        break;
                }


            } while (valg != "1" && valg != "2" && valg != "3");
        }



        // METODER TIL OPGAVERNE

        // Variablerne

        // metode der returnerer alt kode
        static void Variable1() // here laves opgaven
        {
            Console.Clear(); // rydder konsolvinduet
            int tal1, tal2;  // erklærer to variabler

            tal1 = 5;        // værdien til variabler
            tal2 = 3;
            Console.WriteLine(tal1); // udskriver værdien af variable
            Console.WriteLine(tal2);
            Console.WriteLine(string.Empty); // giver et space i cmd'en
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow; // Sætter tekstfarve
            Console.WriteLine(" Et tastetryk til at komme tilbage til den Variabler Opgaverne. Tak :)");

            Console.ReadKey(); // programmet venter på et tastetryk
            VariablerSubMenu(); // variabler Submenu kaldes
        }

        static void Variable2()
        {
            Console.Clear();
            int tal1, tal2;

            tal1 = 5;
            tal2 = 3;
            Console.WriteLine(" Tal1 er " + tal1);
            Console.WriteLine(" Tal2 er " + tal2);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Et tastatryk til at komme tilbage til den Variabler Opgaverne. Tak :)");

            Console.ReadKey();
            VariablerSubMenu();

        }

        static void Variable3()

        {
            Console.Clear();
            string navn = "Søren"; // værdien til string 
            int alder = 16;
            float penge = 123.34f;
            Console.WriteLine(" Jeg hedder {0} , er {1} år gammel og har tjent {2} kr." + " på at lappe cykler", navn, alder, penge);


            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Variabler Opgaverne. Tak :)");
            Console.ReadKey();

            VariablerSubMenu();


        }

        static void Variable4()
        {
            Console.Clear();
            double Kage, Øl, Pølse, Beregning;
            Kage = 23.56;
            Øl = 34.67;
            Pølse = 65.34;
            Beregning = Kage + Øl + Pølse;

            Console.WriteLine(" Kage\t\t\t" + Kage);
            Console.WriteLine(" Øl\t\t\t" + Øl);
            Console.WriteLine(" Pølse\t\t\t" + Pølse);
            Console.WriteLine(" I alt beregning\t{0:N2} ", Beregning);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Variabler Opgaverne. Tak :)");
            Console.ReadKey(); // venter på et tastetryk før programmet går videre

            VariablerSubMenu();
        }

        static void Variable5()
        {
            Console.Clear();
            String navn;
            int alder;

            Console.Write(" Indtast dit navn:");
            navn = Console.ReadLine();
            Console.Write(" Indtast dit alder:");
            alder = int.Parse(Console.ReadLine());
            Console.WriteLine(" Jeg hedder {0} og er {1} år gammel.", navn, alder);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Variabler Opgaverne. Tak :)");
            Console.ReadKey();

            VariablerSubMenu();

        }

        static void Variable6()
        {
            Console.Clear();
            double Radius, Areal;
            Console.Write(" Indtast Radius af cirkel i cm:");
            Radius = double.Parse(Console.ReadLine());
            Areal = Math.PI * Math.Pow(Radius, 2); // Math.Pi indbygget metode
            Console.WriteLine(" Areal (A= PIr²) af cirkel er : {0:0.00}cm²", Areal);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Variabler Opgaverne. Tak :)");
            Console.ReadKey();

            VariablerSubMenu();


        }


        //Strings

        static void String1()
        {
            Console.Clear();
            int number = 1;
            string word = "TEC";
            double number1 = 14.56;
            Console.Write("\n{0}\n{1}\n{2}\n", number, word, number1);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Strings Opgaverne. Tak :)");
            Console.ReadKey();

            StringsSubMenu(); // dette returnere brugeren til String under menu

        }

        static void String2()
        {
            Console.Clear();
            Console.Clear();
            int number = 1;
            string word = "TEC";
            double number1 = 14.56;
            number = 20;
            Console.Write(" {0}\n{1}\n{2}", number, word, number1);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Strings Opgaverne. Tak :)");
            Console.ReadKey();

            StringsSubMenu();
        }

        static void String3()
        {
            Console.Clear();
            string sætning = " I dag har vi den 24. December.";
            Console.WriteLine(sætning);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Strings Opgaverne. Tak :)");
            Console.ReadKey();

            StringsSubMenu();
        }

        static void String4()
        {
            Console.Clear();
            double number = 200.50;
            string tekst1 = " Jeg har ";
            string tekst2 = "kr.i banken.";
            string sætning = string.Concat(tekst1, number, tekst2);
            Console.WriteLine(sætning);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den Strings Opgaverne. Tak :)");
            Console.ReadKey();

            StringsSubMenu();



        }


        // Aritmetiskeudtryk
        static void AritmetiskeUdtryk()
        {
            Console.Clear();
            double arit1, arit2, arit3, arit4, arit5;
            arit1 = 2 + 1 * 3;
            arit2 = (2 + 1) * 2;
            arit3 = 5 / 2;
            arit4 = 8 % 3;
            arit5 = 1 - 5;

            Console.WriteLine("  2+1*3 = " + arit1);
            Console.WriteLine(" (2+1) *2 =" + arit2);
            Console.WriteLine(" 5/2 =" + arit3);
            Console.WriteLine(" 8 % 3 =" + arit4);
            Console.WriteLine(" 1-5 =" + arit5);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til alle Opgaverne. Tak :)");
            Console.ReadKey();

            HovedMenu();

        }


        static void VariableriUdtryk1()

        {
            Console.Clear();
            int num1, num2, num3, result;
            num1 = 10;
            num2 = 20;
            num3 = 30;
            result = num1 + num2 * num3;
            Console.WriteLine(" 10 + 20 * 30 = " + result);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den variabler i Udtryker Opgaverne. Tak :)");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til alle Opgaverne. Tak :)");
            Console.ReadKey();

            VariableriUdtrykSubMenu();


        }

        static void VariableriUdtryk2()

        {
            Console.Clear();
            double num1, num2, num3, result;
            num1 = 10;
            num2 = 20;
            num3 = 30;
            result = num1 - 5 + num2 + 4 * num3 - 2;
            Console.WriteLine(" num1 - 5 + num2 + 4 * num3 - 2 = " + result);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til den variabler i Udtryker Opgaverne. Tak :)");
            Console.ReadKey();

            VariableriUdtrykSubMenu();

        }


        // Boolskevariable
        static void BoolskeVariable()

        {
            Console.Clear();
            int var1, var2;
            var1 = 10;
            var2 = 20;
            bool check = var1 > var2;// erklærer en variabel der tjekker om et statement er true/false
            Console.WriteLine(" var1 =10\n var2 = 20 \n Boolean : var1>var2");
            Console.WriteLine(var1 > var2);
            Console.WriteLine(" Boolean: var1<vae2");
            Console.WriteLine(var1 < var2);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til alle opgaverne. Tak :)");

            Console.ReadKey();
            HovedMenu(); // dette returnere brugeren til Hovedmenu
        }


        // If- Else Statement
        static void IfElseStatement1()
        {
            Console.Clear();
            int tal1, tal2, result;
            tal1 = 42;
            tal2 = 64;
            result = tal1 + tal2;
            Console.WriteLine("tal = 42\ntal2=64\nresult = {0}", result);

            if (result > 100) // if statement
                Console.WriteLine(" Summen er større end 100.");
            else if (result < 100) // else if 
                Console.WriteLine("Summen er mindre end 100");
            else
                Console.WriteLine("Summen er 100");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");

            Console.ReadKey();
            IfElseStatementsSubMenu();



        }

        static void IfElseStatement2()
        {

            Console.Clear();
            int alder;
            Console.WriteLine(" indtast din alder:");
            alder = int.Parse(Console.ReadLine());

            if (alder > 57)
                Console.WriteLine(" Du er for gammel.");
            else
                Console.WriteLine(" Du er ikke for gammel");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");
            Console.ReadKey();

            IfElseStatementsSubMenu();




        }

        static void IfElseStatement3()
        {
            Console.Clear();
            int alder;
            Console.WriteLine(" indtast din alder:");
            alder = int.Parse(Console.ReadLine());
            if (alder > 60)
                Console.WriteLine(" Du er for gammel");

            else if (alder >= 50 && alder <= 60)
                Console.WriteLine(" Du er hverken for gammel eller for ung");

            else
                Console.WriteLine(" Du er for ung");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");
            Console.ReadKey();
            IfElseStatementsSubMenu();

        }

        static void IfElseStatement4()
        {

            Console.Clear();
            string brugernavn, password;
            string navn, indBrugernavn, indPassword;
            brugernavn = "benjina";
            password = "paudyal";
            Console.WriteLine(" Indtast dit navn:");
            navn = Console.ReadLine();
            Console.WriteLine(" Indtast din brugernavn:");
            indBrugernavn = Console.ReadLine();
            Console.WriteLine(" Indtast din password:");
            indPassword = Console.ReadLine();

            if (indBrugernavn == brugernavn && indPassword == password)
                Console.WriteLine(" Velkommen {0}", navn);
            else
                Console.WriteLine(" Brugernavn eller password er forkert.");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");
            Console.ReadKey();

            IfElseStatementsSubMenu();


        }

        static void IfElseStatement5()
        {
            Console.Clear();
            string brugernavn, password;
            string navn, indBrugernavn, indPassword;
            brugernavn = "benjina";
            password = "paudyal";
            Console.WriteLine(" Indtast dit navn:");
            navn = Console.ReadLine();
            Console.WriteLine(" Indtast din brugernavn:");
            indBrugernavn = Console.ReadLine();

            if (indBrugernavn == brugernavn)
            {

                Console.WriteLine(" Indtast din password:");
                Console.ForegroundColor = ConsoleColor.Black;
                indPassword = Console.ReadLine();
                Console.ResetColor();

                if (indPassword == password)

                {

                    Console.WriteLine(" Velkommen {0}", navn);
                }

                else
                {

                    Console.WriteLine(" Passwordet er forkert");

                }

            }
            else

            {
                Console.Clear();
                Console.WriteLine("Brugernavnet er forkert");

            }
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");
            Console.ReadKey();

            IfElseStatementsSubMenu();

        }

        static void IfElseStatement6()
        {
            Console.Clear();
            double totalKm, Fradrag1, Fradrag2;
            Console.WriteLine("Hvor mange km køres du hver dag til og fra arbejde?");
            totalKm = double.Parse(Console.ReadLine());

            if (totalKm <= 24)
            {
                Console.WriteLine("Du får ikke noget fradrag");

            }
            else if (totalKm > 24 && totalKm <= 120)
            {

                Fradrag1 = ((totalKm - 24) * 1.93);
                Console.WriteLine(" Du får {0:0.00} fradrag fordi du køre {1} km til og fra arbejde", Fradrag1, totalKm);
            }

            else if (totalKm > 120)

            {

                Fradrag2 = ((96 * 1.93 + (totalKm - 120) * 0.97));
                Console.WriteLine(" Du får {0:0.00} fradrag fordi du køre {1} km til og fra arbejde", Fradrag2, totalKm);

            }

            else
            {
                Console.Clear();
                Console.WriteLine(" Du skal indtastr over 0 km.");

            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");
            Console.ReadKey();

            IfElseStatementsSubMenu();

        }

        static void IfElseStatement7()
        {

            string farve;

            do
            {
                int alder;
                Console.Clear();
                Console.Title = "Festen";
                Console.WriteLine("Rød [R]\nGrøn[G]\nBlå[B]\nGul[Gu]");
                Console.WriteLine(" Hvilken farve foretrækker du ?");
                farve = Console.ReadLine().ToLower();



                if (farve == "r")
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Hvor gammel er du?");
                    alder = int.Parse(Console.ReadLine());

                    if (alder >= 18)

                    {
                        Console.WriteLine(" Velkommen til Cocktailbare");
                        Thread.Sleep(1000);
                    }

                    else
                    {
                        Console.WriteLine(" Velkommen til Sodavandsbare");
                        Thread.Sleep(10000);
                    }

                }

                else if (farve == "g")

                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Hvor gammel er du?");
                    alder = int.Parse(Console.ReadLine());


                    if (alder >= 18)

                    {
                        Console.WriteLine(" Velkommen til Cocktailbare");
                        Thread.Sleep(10000);
                    }

                    else
                    {
                        Console.WriteLine(" Velkommen til Sodavandsbare");
                        Thread.Sleep(10000);
                    }

                }

                else if (farve == "b")

                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Hvor gammel er du?");
                    alder = int.Parse(Console.ReadLine());

                    if (alder >= 18)

                    {
                        Console.WriteLine(" Velkommen til Cocktailbare");
                        Thread.Sleep(10000);
                    }

                    else
                    {
                        Console.WriteLine(" Velkommen til Sodavandsbare");
                        Thread.Sleep(10000);
                    }

                }

                else if (farve == "gu")

                {

                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    Console.WriteLine("Hvor gammel er du?");
                    alder = int.Parse(Console.ReadLine());

                    if (alder >= 18)

                    {
                        Console.WriteLine(" Velkommen til Cocktailbare");
                        Thread.Sleep(10000);
                    }

                    else
                    {
                        Console.WriteLine(" Velkommen til Sodavandsbare");
                        Thread.Sleep(10000);
                    }

                }

                else
                {
                    Console.Clear();
                    Console.WriteLine(" Prøv igen!!");
                    Console.ReadKey();

                }


            }

            while (farve != "r" && farve != "g" && farve != "b" && farve != "gu");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Festen";

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til If-Else statement Opgaverne. Tak :)");
            Console.ReadKey();

            IfElseStatementsSubMenu();


        }



        // Switch Case

        static void SwitchCase1()
        {
            string valg; // string erklæret

            do

            {
                Console.Clear();
                Console.WriteLine(" Indaste en tal mellem 1 & 6");
                valg = Console.ReadLine();
                switch (valg) // switch case starter 
                {

                    case "1":
                        Console.Clear();
                        Console.WriteLine(" Du har tastet 1");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" Du har tastet 2");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(" Du har tastet 3");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.SetCursorPosition(50, 15);
                        Console.WriteLine(" TILLYKKE DU HAR VUNDET");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(" Du har tastet 5");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine(" Du har tastet 6");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6");
                        Thread.Sleep(1000);
                        break;
                }

            }
            while (valg != "1" && valg != "2" && valg != "3" && valg != "4" && valg != "5" && valg != "6");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Switch-Case Opgaverne. Tak :)");
            Console.ReadKey();

            SwitchCaseSubMenu();


        }

        static void SwitchCase2()
        {

            string drink;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Vælg en drink :");
                Console.WriteLine(string.Empty);
                Console.ResetColor();
                Console.WriteLine(" [1] Isbjørn ---- 40 Kr.");
                Console.WriteLine(" [2] Champagnebrus ---- 100 Kr.");
                Console.WriteLine(" [3] Tequila Sunrise ---- 45 Kr.");
                Console.WriteLine(" [4] Mojito ---- 125 Kr.");
                Console.WriteLine(" [5] Brandbil ---- 30 Kr.");
                Console.WriteLine(" [6] Filur ---- 50 Kr.");
                drink = Console.ReadLine();

                switch (drink)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(" Du har valgt 'Isbjørn' og de koster 40 Kr.");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" Du har valgt 'Champagnebrus' og de koster 100 Kr.");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(" Du har valgt 'Tequila Sunrise' og de koster 100 Kr.");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(" Du har valgt ' Mojito' og de koster 125 Kr.");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(" Du har valgt 'Brandbil' og de koster 30 Kr.");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine(" Du har valgt 'Filur' og de koster 50 Kr.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(" du har valgt forkert. Prøv igen !!!");
                        Console.ReadKey();
                        break;
                }

            }
            while (drink != "1" && drink != "2" && drink != "3" && drink != "4" && drink != "5" && drink != "6");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Switch-Case Opgaverne. Tak :)");
            Console.ReadKey();

            SwitchCaseSubMenu();
        }


        // Loops

        static void Loop1()
        {
            int i;
            Console.Clear();
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(String.Empty);

            i = 1;

            while (i < 11)
            {
                Console.WriteLine(i);
                i = i + 1;

            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();

        }

        static void Loop2()
        {
            Console.Clear();
            int i;
            for (i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(String.Empty);

            i = 100;

            while (i >= 1)
            {

                Console.WriteLine(i);
                i = i - 1;
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();

            LoopSubMenu();



        }

        static void Loop3()
        {
            Console.Clear();
            for (int i = 5; i < 51; i = i + 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();

        }

        static void Loop4()
        {
            Console.Clear();
            int i;

            for (i = 20; i <= 0; i--)
            {
                Console.WriteLine(i);
            }


            i = 20;
            while (i >= 0)
            {
                Console.WriteLine(i--);
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();

        }

        static void Loop5()
        {
            Console.Clear();

            int n = 7;
            for (int i = 1; i < 11; i++)
            {
                Console.Write(" {0} * {1} = {2} \n", n, i, n * i);
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();

        }

        static void Loop6()
        {
            Console.Clear();
            int n;

            Console.WriteLine(" Indtast den ønskede table: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.Write(" {0} * {1} = {2} \n", n, i, n * i);
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();

        }

        static void Loop7()
        {
            Console.Clear();

            for (int i = 20; i <= 30; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.WriteLine("*");
                Console.SetCursorPosition(i, 8);
                Console.WriteLine("*");
            }

            for (int i = 4; i <= 8; i++)

            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("*");
                Console.SetCursorPosition(30, i);
                Console.WriteLine("*");
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();


        }

        static void Loop8()
        {

            Console.Clear();

            for (int i = 20; i <= 30; i++)
            {
                Console.SetCursorPosition(i, 4);
                Console.WriteLine("*");
                Console.SetCursorPosition(i, 8);
                Console.WriteLine("*");
            }

            for (int i = 4; i <= 8; i++)

            {
                Console.SetCursorPosition(20, i);
                Console.WriteLine("*");
                Console.SetCursorPosition(30, i);
                Console.WriteLine("*");
            }

            Console.SetCursorPosition(22, 6);
            Console.WriteLine("BENJINA");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
            Console.ReadKey();
            LoopSubMenu();



        }

        static void Loop9()

        {
            Console.Write("Indtast længeden af rammen(Mindst:10.. Max:119):");
            int længde = int.Parse(Console.ReadLine());
            Console.Write("Indtast bredden af ramme ( Mindst:2 .. Max: 28):");
            int bredde = int.Parse(Console.ReadLine());
            Console.Write("Indtast navn:");
            string navn = Console.ReadLine();
            int length = navn.Count();
            Console.Clear();
            for (int x = 0; x < længde + 1; x++)
            {
                if (længde > 119 || længde < 10 || bredde < 2 || bredde > 28)
                {
                    Console.WriteLine(" Dit tal på rammen skal være i mellem minimum og maximum værdi.");
                    break;
                }

                else
                {
                    Console.SetCursorPosition(x, 0);
                    Console.Write("*");
                    Console.SetCursorPosition(x, bredde);
                    Console.Write("*");
                }
            }

            for (int y = 0; y < bredde; y++)
            {
                if (bredde < 2 || bredde > 28 || længde > 119 || længde < 10)
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write("*");
                    Console.SetCursorPosition(længde, y);
                    Console.Write("*");
                }

            }
            if (bredde >= 2 && bredde <= 28 && længde <= 119 && længde >= 10)
            {
                double længdeNavn = længde * 0.5 - length * 0.5;
                double breddeNavn = bredde * 0.5;
                Console.SetCursorPosition(Convert.ToInt32(længdeNavn), Convert.ToInt32(breddeNavn));
                Console.Write(navn);
                Console.ReadKey();
            }

            /* Console.WriteLine(string.Empty);
             Console.WriteLine(string.Empty);
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine("  Et tastatryk til at komme tilbage til Loops Opgaverne. Tak :)");
             Console.ReadKey();
             LoopSubMenu();*/

        }


        // Udvidet kontrolstrukturer

        static void UdvidetKontrolstrukturer1()
        {
            Console.Clear();

            int n = 3;
            for (int i = 1; i < 11; i++)
            {
                if ((n * i) == 21)
                {

                    Console.WriteLine("Loopen er nu stoppet.");
                    break;
                }
                Console.WriteLine(" {0} * {1} = {2} \n", n, i, n * i);
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Udvidet Kontrolstrukture Opgaverne. Tak :)");
            Console.ReadKey();
            UdvidetKontrolstrukturerSubMenu();


        }

        static void UdvidetKontrolstrukturer2()
        {
            Console.Clear();

            int n = 4;
            for (int i = 1; i < 11; i++)
            {
                if ((n * i) == 16)
                {
                    i = i + 1;

                }
                Console.WriteLine(" {0} * {1} = {2} \n", n, i, n * i);

            }
            Console.Write("loopen er nu stoppet");

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Udvidet Kontrolstrukture Opgaverne. Tak :)");
            Console.ReadKey();
            Console.ReadKey();
            UdvidetKontrolstrukturerSubMenu();


        }

        static void UdvidetKontrolstrukturer3()
        {
            Console.Clear();
            double distance, fradrag1, fradrag2;

            Console.WriteLine(" Indtast distance kørt hver dag til og fra arbejde i km:");
            distance = double.Parse(Console.ReadLine());
            if (distance <= 24)
            {
                Console.WriteLine(" Du får ikke noget fradrag.");
            }
            else if (distance >= 25 && distance <= 100)
            {
                fradrag1 = (distance - 24) * 1.54;
                Console.WriteLine(" Du får {0:0.00} fradrag fordi du køre {1} km til og fra arbejde", fradrag1, distance);

            }

            else if (distance > 100)
            {
                fradrag2 = 76 * 1.54 + (distance - 100) * 0.77;
                Console.WriteLine("Du får {0:0.00} fradrag fordi du køre {1} km til og fra arbejde", fradrag2, distance);

            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Udvidet Kontrolstrukture Opgaverne. Tak :)");
            Console.ReadKey();
            UdvidetKontrolstrukturerSubMenu();


        }

        static void UdvidetKontrolstrukturer4()
        {
            Console.Clear();
            double indkomst, skat;
            Console.WriteLine(" Indtast din indkomst:");
            indkomst = double.Parse(Console.ReadLine());

            if (indkomst < 42000)
            {
                Console.WriteLine(" Du skal ikke betales skat. :)");
            }

            else if (indkomst >= 42000 && indkomst < 280000)
            {
                skat = indkomst * 0.3;
                Console.WriteLine(" Du skal betale {0} kr. som bundskat(30%) fordi din indkomst er {1:N3}", skat, indkomst);
            }

            else if (indkomst >= 280000)
            {
                skat = 280000 * 0.3 + (indkomst - 280000) * 0.06;
                Console.WriteLine(" Du skal betale {0} kr. som bundskat(30%) til 280000kr. og mellemskat(6% )af resten fordi din indkomst er {1:N3}", skat, indkomst);
            }

            else
            {
                skat = (280000 * 0.3) + (110000 * 0.06) + ((indkomst - 390000) * 0.15);
                Console.WriteLine(" Du skal betale {0} kr. som bundskat (30%) til 280000kr. og mellemskat (6%) til 110000 kr. og topskat(15%) af resten fordi din indkomst er {1:N3}", skat, indkomst);

            }

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Udvidet Kontrolstrukture Opgaverne. Tak :)");
            Console.ReadKey();
            UdvidetKontrolstrukturerSubMenu();





        }

        static void UdvidetKontrolstrukturer5()
        {
            Console.Clear();
            double beløb, rente;
            Console.WriteLine(" hvor mange penge der står på kontoen?");
            beløb = double.Parse(Console.ReadLine());

            if (beløb < 25000)
            {
                rente = beløb * 0.0025;
                Console.WriteLine(" Du kan får {0:N2} kr. som rente ", rente);

            }

            else if (beløb <= 25000 && beløb > 150000)
            {
                rente = beløb * 0.0125;
                Console.WriteLine(" Du kan får {0:N2} kr. som rente", rente);

            }

            else
            {
                rente = (150000 * 0.0125) + (beløb - 150000) * 0.005;
                Console.WriteLine(" Du kan får {0:N2} kr. som rente", rente);

            }


            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Udvidet Kontrolstrukture Opgaverne. Tak :)");
            Console.ReadKey();
            UdvidetKontrolstrukturerSubMenu();

        }


        // Arrays

        static void Array1()
        {
            Console.Clear();
            int[] array1 = { -2, -1, 0, 10 }; // array med 4 værdi
            int[] array2 = new int[4]; // 4 array erklæring med uden værdi
            array2[0] = -2;
            array2[1] = -1;
            array2[2] = 0;
            array2[3] = 10;

            Console.WriteLine(" Værdi af array1 : " + array1[1] + "\n Værdi af array3: " + array1[3]);

            int arraySum1 = array1.Sum();// indbygget metode at lave sum
            int arraySum2 = array2.Sum();

            Console.WriteLine(" Sum af Array1: " + arraySum1 + "\n Sum af Array2: " + arraySum2);

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Arrays Opgaverne. Tak :)");
            Console.ReadKey();
            ArraySubMenu();
        }

        static void Array2()

        {
            int[] Nummer = { -2, -1, 0, 1, 2, 3 };
            int Sum = 0;

            for (int i = 0; i < 6; i++)
            {
                Sum = Sum + Nummer[i];
            }

            Console.WriteLine(" Sum af array :" + Sum);


            string[] Sætning = { "Hej", " Jonas,", " Jeg", " hedder", " Benjina." };

            foreach (string value in Sætning)
            {
                Console.Write(value);

            }


            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  Et tastatryk til at komme tilbage til Arrays Opgaverne. Tak :)");
            Console.ReadKey();
            ArraySubMenu();

        }

    }

}
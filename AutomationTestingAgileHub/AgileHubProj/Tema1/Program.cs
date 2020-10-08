using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Ex7();
            Ex8();
            Ex9();
            Ex10();
            Ex11();
            Ex12();
            Ex13();
            Ex14();
            Ex15();
            Ex16();
            Ex17();
            Ex18();
            Ex19();
            Ex20();
            Ex21();
            Ex22();
            Ex23();
            Ex24();
            Ex25();
            Ex26();
            Ex27();
            Ex28();
            Ex29();
            Ex30();
            Ex31();
            Ex32();
            Ex33();
            Ex34();
            Ex35();
            Ex36();
            Ex37();
            Ex38();
            Ex39();
            Ex40();
            Ex41();
            Ex42();
            Ex43();
            Ex44();
            Ex45();
            Ex46();
            
        }


        public static void Ex1()
        {
            //1.	Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
            Console.WriteLine("Introduceti un nr:");
            int n = Int32.Parse(Console.ReadLine());

            if (n == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
        }

        public static void Ex2()
        {
            // 2.	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””.

            Console.WriteLine("Introduceti un cuvant:");
            string txt = Console.ReadLine();

            if (txt.Equals("automation"))
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”");
            }
        }

        public static void Ex3()
        {
            // 3.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”

            Console.WriteLine("Introduceti un caracter:");
            char c = Console.ReadLine()[0];

            if (Char.IsDigit(c))
            {
                Console.WriteLine($"Caracterul  {c} pe care l-ai introdus este cifra!");
            }
        }

        public static void Ex4()
        {
            // 4.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse( Console.ReadLine());

            if ( n < 20)
            {
                n += 5;
                Console.WriteLine($"{n}");
            }
            else
            {
                Console.WriteLine($"{n}");
            }
        }

        public static void Ex5()
        {
            // 5.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse( Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine($"Numarul {n} este pozitiv");
            }

        }

        public static void Ex6()
        {
            // 6.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n < 20 || n > 40)
            {
                Console.WriteLine($"Numarul este mai mic de 20 sau mai mare de 40!");
            }

        }

        public static void Ex7()
        {
            // 7.	Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar nu afisati nimic

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"Numarul {n} pe care l’ati introdus este par! ");
            }

        }

        public static void Ex8()
        {
            // 8.	Cititi de la tastatura un numar. Verificati daca numarul este egal cu 20. In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau este diferit de 20");
            }

        }

        public static void Ex9()
        {
            // 9.	Cititi de la tastatura un cuvant. Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text :” Cuvantul pe care tu l-ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.

            Console.WriteLine("Introduceti un numar:");
            string txt = Console.ReadLine();

            if (txt.Equals("automation"))
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este “automation”");
            }else
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit nu este “automation”");
            }

        }

        public static void Ex10()
        {
            // 10.	Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul  *character* pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul *character* pe care l-ai introdus nu este cifra.

            Console.WriteLine("Introduceti un caracter:");
            char c = Console.ReadLine()[0];

            if (Char.IsDigit(c))
            {
                Console.WriteLine($"Caracterul  {c} pe care l-ai introdus este cifra!");
            }
            else
            {
                Console.WriteLine($"Caracterul  {c} pe care l-ai introdus nu este cifra!");
            }

        }

        public static void Ex11()
        {
            // 11.	Cititi de la tastatura un numar. In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n < 20)
            {
                n += 5;
                Console.WriteLine($"{n}");
            }
            else
            {
                n -= 5;
                Console.WriteLine($"{n}");
            }

        }

        public static void Ex12()
        {
            // 12.	Cititi de la tastatura un numar. Verificati daca numarul este pozitiv si afisati: “Numarul *numar* este pozitiv”. In caz contrar afisati “Numarul *numar* este negativ!.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine($"Numarul {n} este pozitiv");
            }
            else
            {
                Console.WriteLine($"Numarul {n} este negativ");
            }

        }

        public static void Ex13()
        {
            // 13.	Cititi de la tastatura un numar. Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n < 20 || n > 40)
            {
                Console.WriteLine($"Numarul este mai mic de 20 sau mai mare de 40!");
            }
            else
            {
                Console.WriteLine($"Numarul este intre 20 si 40");
            }

        }

        public static void Ex14()
        {
            // 14.	Cititi de la tastaura un numar. Verificati daca numarul este par. Daca numarul este par afisati :”Numarul *numar* pe care l’ati introdus este par!”. In caz contrar afisati “Numarul *numar* pe care l’ati introdus este impar!”.

            Console.WriteLine("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"Numarul {n} pe care l’ati introdus este par! ");
            }
            else
            {
                Console.WriteLine($"Numarul {n} pe care l’ati introdus este impar! ");
            }


        }


        public static void Ex15()
        {
            // 15.	Cititi de la tastatura un caracter. Daca acel caracter este litera afisati mesajul :”Caracterul *caracter* este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul *caracter* este o cifra!”. In cazul contrar afisati mesajul: “Caracterul *caracter* nu este nici cifra nici litera


            Console.WriteLine("Introduceti un caracter:");
            char c = Console.ReadLine()[0];

            if (Char.IsLetterOrDigit(c))
            {
                if (Char.IsDigit(c))
                {
                    Console.WriteLine($"Caracterul  {c} pe care l-ai introdus este cifra!");
                }
                else
                {
                    Console.WriteLine($"Caracterul  {c} pe care l-ai introdus este o litera!");
                }
            }
            else
            {
                Console.WriteLine($"Caracterul {c} nu este nici cifra nici litera");
            }


        }

        public static void Ex16()
        {
            // 16.	Cititi de la tastatura o ora a zilei. In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul :”Buna seara!”

            Console.WriteLine("Introduceti o ora a zilei");
            int n = Int32.Parse(Console.ReadLine());


            if (n < 12)
            {
                Console.WriteLine("Buna dimineata!");
            }
            else if (n < 17)
            {
                Console.WriteLine("Buna ziua!");
            }
            else
            {
                Console.WriteLine("Buna seara!");
            }


        }


        public static void Ex17()
        {
            // 17.	Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este <150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si <195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.

            Console.WriteLine("Introduceti inaltimea unei persoane: ");
            int n = Int32.Parse(Console.ReadLine());


            if (n < 150)
            {
                Console.WriteLine("Aceasta persoana este miniona");
            }
            else if (n < 165)
            {
                Console.WriteLine("Aceasta persoana este mica de statura");
            }
            else if (n < 195)
            {
                Console.WriteLine("Aceasta persoana este inalta");
            }else
            {
                Console.WriteLine("Aceasta persoana este foarte inalta");
            }
        }

        public static void Ex18()
        {
            //18.	Cititi 3 numere de la tastatura si afisati cel mai mare numar.

            Console.WriteLine("Introduceti primul nr: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea nr: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea nr: ");
            int c = Int32.Parse(Console.ReadLine());


            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
            else if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }

        public static void Ex19()
        {
            // 19.	Cititi de la tastatura 2 numere. Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul: 

            Console.WriteLine("Introduceti primul nr: ");
            int nr1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea nr: ");
            int nr2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un operator (+, -, *, /):");
            char op = Console.ReadLine()[0];


            switch (op)
            {
                case '+':
                    Console.WriteLine($"{nr1} {op} {nr2} = {nr1 + nr2}");
                    break;
                case '-':
                    Console.WriteLine($"{nr1} {op} {nr2} = {nr1 - nr2}");
                    break;
                case '*':
                    Console.WriteLine($"{nr1} {op} {nr2} = {nr1 * nr2}");
                    break;
                case '/':
                    Console.WriteLine($"{nr1} {op} {nr2} = {nr1 / nr2}");
                    break;
                default:
                    Console.WriteLine("You didn't choose an operator");
                    break;
            }
        }

        public static void Ex20()
        {
            // 20.	Scrieti un program care sa afiseze primele 10 numere naturale.

            for (int i=0; i <= 10; i++)
                Console.Write($"{i},");
        }

        public static void Ex21()
        {
            // 21.	Scrieti un program care sa afiseze suma primelor 10 numere naturale.
            int nr = 0;

            for (int i = 0; i <= 10; i++)
                nr += i;

            Console.WriteLine(nr);
        }

        public static void Ex22()
        {
            // 22.	Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.
            Console.WriteLine("Introduceti un nr: ");
            int n = Int32.Parse(Console.ReadLine());

            for ( int i = n; i > 0; i--)
                Console.Write($"{i},");
        }

        public static void Ex23()
        {
            // 23.	Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi.
            Console.WriteLine("Introduceti un nr: ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 3; i <= n; i++)
                Console.Write($"{i},");
        }

        public static void Ex24()
        {
            // 24.	Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi.
            Console.WriteLine("Introduceti un nr: ");
            int n = Int32.Parse(Console.ReadLine());

            int suma = 0;

            for (int i = 0; i < n; i++)
                suma += i;

            Console.Write(suma);
        }

        public static void Ex25()
        {
            // 25	Afisati cubul primelor 5 numere naturale.

            for (int i = 1; i <6; i++)
                Console.WriteLine(i*i*i);
        }

        public static void Ex26()
        {
            // 26.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.
            Console.WriteLine("Introduceti un nr: ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
        }
        public static void Ex27()
        {
            // 27.	Scrieti un program care sa afiseze primele 10 numere naturale.( do while)

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <=10);
        }

        public static void Ex28()
        {
            // 28.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. ( do while)

            int i = 0;
            int nr = 0;
            do
            {
                nr += i;
                i++;
            } while (i <= 10);

            Console.WriteLine(nr);
        }

        public static void Ex29()
        {
            // 29.	Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. .( do while)

            Console.WriteLine("Introduceti un nr: ");
            int n = Int32.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(n);
                n--;
            } while (n > 0);
        }

        public static void Ex30()
        {
            // 30.	Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. .( do while)

            Console.WriteLine("Introduceti un nr: ");
            int n = Int32.Parse(Console.ReadLine());

            int i = 3;
            do
            {
                Console.WriteLine(i);
                i++; 
            } while (i < n);
        }

        public static void Ex31()
        {
            // 31.	Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. .( do while)

            Console.WriteLine("Introduceti un nr: ");
            int nr = Int32.Parse(Console.ReadLine());

            int n = 0;
            int i = 0;
            do
            {
                n += i;
                i++;
            } while (i <= nr);

            Console.WriteLine(n);
        }

        public static void Ex32()
        {
            // 32.	Afisati cubul primelor 5 numere naturale. .( do while)

            int i = 0;
            do
            {
                Console.WriteLine(i*i*i); ;
                i++;
            } while (i < 5);
        }

        public static void Ex33()
        {
            // 33.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. .( do while)

            Console.WriteLine("Introduceti un nr: ");
            int nr = Int32.Parse(Console.ReadLine());

            int i = 0;
            do
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i < nr);
        }

        public static void Ex34()
        {
            // 34.	Scrieti un program care sa afiseze primele 10 numere naturale. (for)

            for (int i = 0; i <= 10; i++)
                Console.Write($"{i},");
        }

        public static void Ex35()
        {
            // 35.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. (for)

            int sum = 0;
            for (int i = 0; i <= 10; i++)
                sum += i;
            Console.WriteLine(sum);
        }

        public static void Ex36()
        {
            // 36.	Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi. (for)

            Console.WriteLine("Introduceti un nr: ");
            int nr = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= nr; i++)
                Console.WriteLine(i);
        }

        public static void Ex37()
        {
            // 37.	Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi. (for)

            Console.WriteLine("Introduceti un nr: ");
            int nr = Int32.Parse(Console.ReadLine());

            for (int i = 3; i <= nr; i++)
                Console.WriteLine(i);
        }

        public static void Ex38()
        {
            // 38.	Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi. (for)

            Console.WriteLine("Introduceti un nr: ");
            int nr = Int32.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= nr; i++)
                sum += i;
            Console.WriteLine(sum);
        }

        public static void Ex39()
        {
            //39.	Afisati cubul primelor 5 numere naturale. (for)

            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i*i*i);
        }

        public static void Ex40()
        {
            // 40.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. (for)

            Console.WriteLine("Introduceti un nr: ");
            int nr = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= nr; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
        }

        public static void Ex41()
        {
            // 41.	Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.

            string[] arr1 = { "sun", "moon", "clouds" };
            Console.WriteLine(arr1[1]);
        }

        public static void Ex42()
        {
            // 42.	Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”

            string[] arr1 = { "lemons", "watermelon", "cherry"};
            Console.WriteLine(arr1[2]);
        }

        public static void Ex43()
        {
            // 43.	Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.

            string[] arr1 = { "mom", "dad", "child" };
            string[] arr2 = arr1;
            Array.Reverse(arr2);

            foreach(string item in arr2)
                Console.WriteLine(item);
        }

        public static void Ex44()
        {
            // 44.	Afisati array-ul sortat: “mom”, “dad”, “child”.

            string[] arr1 = { "mom", "dad", "child" };
            string[] arr2 = arr1;
            Array.Sort(arr2);

            foreach (string item in arr2)
                Console.WriteLine(item);
        }

        public static void Ex45()
        {
            // 45.	Cititi de la tastatura elementele unui array de marime 5. (string)

            string[] arr1 = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduceti un element: ");
                arr1[i] = Console.ReadLine();
            }

            foreach(string item in arr1)
                Console.Write($"{item},");        
        }

        public static void Ex46()
        {
            // 46.	Cititi de la tastatura elementele unui array de marime 5.(int)

            int[] arr1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduceti un element: ");
                arr1[i] = Int32.Parse( Console.ReadLine());
            }

            foreach (int item in arr1)
                Console.Write($"{item},");
        }

    }
}

using System;

namespace Test_Alexis
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Alexis = new Book();
            Alexis.title = "Trouvez Pavlo";
            Alexis.author = "Richard Martineau";
            Alexis.pages = 450;
            Alexis.volume = 0;

            Book Pavlo = new Book();
            Pavlo.title = "Comment j'ai appris a Coder en c# en 4 secondes";
            Pavlo.author = "Martine Michaud";
            Pavlo.pages = 450;
            Pavlo.volume = 0;
            string[] Library = { Alexis.title, Pavlo.title };
            Console.WriteLine("Bonjour ! Bienvenue dans l'imprimante de Alexis Choissisez un livre a imprimer parmi les suivants: ");
            Console.WriteLine("-------------------");
            Console.WriteLine(Library[0] + " (Utilisez: Alexis) ");
            Console.WriteLine("-------------------");
            Console.Write(Library[1] + " (Utilisez: Pavlo) ");
            string imprimante = Console.ReadLine();
            Console.Write("Parfait, combien de volumes a imprimer: ");
            int imprimantepapier = Convert.ToInt32(Console.ReadLine());
            Console.Write("Je vois, Voudriez vous Changer le titre de votre livre ? ");
            string answer = Console.ReadLine();

            if (imprimante == "Alexis" && answer == "oui")
            {
                Console.Write("Choisissez un titre: ");
                Alexis.title = Console.ReadLine();
                Console.WriteLine("Parfait, Nous Envoyons la requete Veuillez Patienter ");
                System.Threading.Thread.Sleep(2000);

                for (Alexis.volume = 0; Alexis.volume <= imprimantepapier; Alexis.volume++)
                {

                    Console.WriteLine(Alexis.title + " Edition: " + Alexis.volume);
                    Console.WriteLine("Votre Livre a " + Alexis.pages + " pages");
                    Console.WriteLine("Votre Livre a ete ecrit par " + Alexis.author);

                }

            }
            else if (imprimante == "Pavlo" && answer == "oui")
            {
                Console.Write("Choisissez un titre: ");
                Pavlo.title = Console.ReadLine();
                Console.WriteLine("Parfait, Nous Envoyons la requete Veuillez Patienter");
                System.Threading.Thread.Sleep(2000);

                {
                    for (Pavlo.volume = 0; Pavlo.volume <= imprimantepapier; Pavlo.volume++)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine(Pavlo.title + " Edition: " + Pavlo.volume);
                    }
                    Console.WriteLine("Votre Livre a " + Pavlo.pages + " pages");
                    Console.WriteLine("Votre Livre a ete ecrit par " + Pavlo.author);
                }
                Console.ReadLine();
            }
            else if (imprimante == "Pavlo" || imprimante == "Alexis" && answer == "non")
            {
                if (imprimante == "Pavlo")

                {
                    Console.WriteLine("Parfait, Nous Envoyons la requete Veuillez Patienter");
                    System.Threading.Thread.Sleep(2000);

                    for (Pavlo.volume = 0; Pavlo.volume <= imprimantepapier; Pavlo.volume++)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Impression En cours de : " + Pavlo.title + "" + " Edition: " + Pavlo.volume);

                    }
                    Console.WriteLine("Votre Livre a " + Pavlo.pages + " pages");
                    Console.WriteLine("Votre Livre a ete ecrit par " + Pavlo.author);
                }
                else if (imprimante == "Alexis")
                {
                    Console.WriteLine("Parfait, Nous Envoyons la requete Veuillez Patienter");
                    System.Threading.Thread.Sleep(2000);


                    for (Alexis.volume = 0; Alexis.volume <= imprimantepapier; Alexis.volume++)
                    {
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Imprimation En cours de " + Alexis.title + "" + " Edition: " + Alexis.volume);
                    }
                    Console.WriteLine("Votre Livre a " + Alexis.pages + " pages");
                    Console.WriteLine("Votre Livre a ete ecrit par " + Alexis.author);
                } else if (imprimante == "Alexis" || imprimante == "Pavlo" && answer == !"Pavlo" || answer = !"Alexis")
                {
                    Console.WriteLine("Va te faire foutre connard ! tu crois que j'ai que ça a faire de ma journée ?");
                    Console.ReadLine();
                }
                Console.WriteLine("Merci d'avoir Utiliser mon imprimante :) ");
                Console.ReadLine();






            }
        }
    }
}
   
  




    

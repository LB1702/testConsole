/**
 * Jeu du nombre caché
 * auteur : LB17
 * date : 09/11/2022
 */

using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration variables
            int valeur;
            int essai;
            int nbre = 1;
            bool correct = false;

            // saisie du nombre à chercher
            while (!correct)
            {
                try
                {
                    Console.Write(" Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine(" Erreur de saisie : saisissez un nombre entier ");
                }
            }
            Console.Clear();

            // saisie du nombre à chercher
            Console.Write("Entrez le nombre à chercher = ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();

            // saisie du premier essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());

            // boucle
            while (essai != valeur)
            {
                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand ! ");
                }
                else
                {
                    Console.WriteLine(" --> trop petit ! ");
                }

                // saisie d'un nouvel essai
                Console.Write(" Entrez un essai = ");
                essai = int.Parse(Console.ReadLine());

                // compteur d'essais
                nbre++;
            }

            // Valeur trouvé
            Console.WriteLine(" Vous avez trouvé en " + nbre + " fois ! ");
            Console.ReadLine();

        }
    }
}

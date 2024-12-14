using System;

namespace ExerciceInsertionDeValeurs // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = [10];

            Console.WriteLine("Insertion des valeurs du tableau :");

            int compteur = 0;
            while (compteur < tableau.Length)
            {
                Console.Write($"Saisir la valeur {compteur} : ");
                tableau[compteur] = int.Parse(Console.ReadLine());
                compteur++;


            }
        }
    }
}
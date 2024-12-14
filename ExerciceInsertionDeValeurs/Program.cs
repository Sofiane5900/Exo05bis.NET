using System;

namespace ExerciceInsertionDeValeurs // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // J'initialise un tableau vide, mais avec une taille de 10
            int[] tableau = new int [10];

            Console.WriteLine("Insertion des valeurs du tableau :");

            
            // Boucle for, tant que mon index est inférieur a la taille de mon tableau la boucle continue
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write($"Saisir la valeur {i + 1} : "); 
                tableau[i] = int.Parse(Console.ReadLine()); // Je stock la saisie de l'utilisateur dans mon tableau dans différentes positions, grace a l'itération de mon int i
            }

            Console.WriteLine("Affichage des valeurs du tableau :");
            Console.WriteLine($"{tableau[0]}");
            Console.WriteLine($"\t{tableau[1]}");
            Console.WriteLine($"\t\t{tableau[2]}");
            Console.WriteLine($"\t\t\t{tableau[3]}");
            Console.WriteLine($"\t\t\t\t{tableau[4]}");
            Console.WriteLine($"\t\t\t\t\t{tableau[5]}");
            Console.WriteLine($"\t\t\t\t\t\t{tableau[6]}");
            Console.WriteLine($"\t\t\t\t\t\t\t{tableau[7]}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t{tableau[8]}");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t{tableau[9]}");
          
        }
    }
}
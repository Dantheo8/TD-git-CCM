using System;
using System.Collections.Generic;

/// <summary>
/// Classe contenant des implémentations de tris classiques
/// </summary>
public class TriClassique
{
    /// <summary>
    /// Tri à bulles (Bubble Sort) - Algorithme classique et simple
    /// Complexité: O(n²) en moyenne et pire cas
    /// </summary>
    public static void TriBulles(int[] tableau)
    {
        int n = tableau.Length;
        
        // Parcourir tout le tableau
        for (int i = 0; i < n - 1; i++)
        {
            // Derniers i éléments sont déjà à leur place
            for (int j = 0; j < n - i - 1; j++)
            {
                // Comparer les éléments adjacents
                if (tableau[j] > tableau[j + 1])
                {
                    // Échanger si nécessaire
                    int temp = tableau[j];
                    tableau[j] = tableau[j + 1];
                    tableau[j + 1] = temp;
                }
            }
        }
    }

    /// <summary>
    /// Tri par sélection (Selection Sort)
    /// Complexité: O(n²) dans tous les cas
    /// </summary>
    public static void TriSelection(int[] tableau)
    {
        int n = tableau.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            // Trouver l'indice du minimum
            int indiceMin = i;
            for (int j = i + 1; j < n; j++)
            {
                if (tableau[j] < tableau[indiceMin])
                {
                    indiceMin = j;
                }
            }
            
            // Échanger
            int temp = tableau[i];
            tableau[i] = tableau[indiceMin];
            tableau[indiceMin] = temp;
        }
    }

    /// <summary>
    /// Tri par insertion (Insertion Sort)
    /// Complexité: O(n²) en moyenne, O(n) meilleur cas
    /// Efficace pour les petits tableaux
    /// </summary>
    public static void TriInsertion(int[] tableau)
    {
        int n = tableau.Length;
        
        for (int i = 1; i < n; i++)
        {
            int cle = tableau[i];
            int j = i - 1;
            
            // Décaler les éléments plus grands
            while (j >= 0 && tableau[j] > cle)
            {
                tableau[j + 1] = tableau[j];
                j--;
            }
            
            // Insérer la clé
            tableau[j + 1] = cle;
        }
    }

    /// <summary>
    /// Afficher un tableau
    /// </summary>
    public static void AfficherTableau(int[] tableau)
    {
        Console.Write("[ ");
        foreach (int num in tableau)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("]");
    }

    // Exemple d'utilisation
    public static void Main()
    {
        int[] nombres = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Tableau original:");
        AfficherTableau(nombres);
        
        // Tri à bulles
        int[] test1 = (int[])nombres.Clone();
        TriBulles(test1);
        Console.WriteLine("\nAprès Tri Bulles:");
        AfficherTableau(test1);
        
        // Tri par sélection
        int[] test2 = (int[])nombres.Clone();
        TriSelection(test2);
        Console.WriteLine("\nAprès Tri Sélection:");
        AfficherTableau(test2);
        
        // Tri par insertion
        int[] test3 = (int[])nombres.Clone();
        TriInsertion(test3);
        Console.WriteLine("\nAprès Tri Insertion:");
        AfficherTableau(test3);
    }
}

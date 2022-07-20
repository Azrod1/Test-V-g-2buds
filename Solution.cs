using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    // Tableau de test
    public double[] ints = { 7, -10, 13, 8, 4, -7.2, -12, -3.7, 3.5, -9.6, 6.5, -1.7, -6.2, 7 };
    public double[] intsNull;

    void Start()
    {
        double result;
        result = ClosesToZero(ints); // pour tester avec un tableau
        //result = ValueTo(intsNull); // pour tester avec un tableau vide
        Debug.Log(result); // résultat afficher dans la console (unity)
    }

    public static double ClosesToZero(double[] ts)
    {
        // Variable temporaire
        double min;
        int indexMin;
        double transformValue;

        // Si le tableau est vide
        if (ts.Length == 0){
            return 0.0;
        }

        // Première valeur du tableau
        min = ts[0] >= 0 ? ts[0] : 0 - ts[0];
        indexMin = 0;

        // Boucle pour trouver la valeur la plus proche de 0 
        for (int i = 0; i < ts.Length; i++){
            if (ts[i] <= min && ts[i] > 0.0){
                min = ts[i];
                indexMin = i;
            }
            else if (ts[i] < 0.0){
                transformValue = 0.0 - ts[i];
                if (transformValue < min)
                {
                    min = transformValue;
                    indexMin = i;
                }
            }
            else if (ts[i] == 0.0){
                return 0.0;
            }
        }

        return ts[indexMin];
    }
}

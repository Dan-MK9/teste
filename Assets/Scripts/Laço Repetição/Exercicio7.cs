using System.Drawing;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio7 : MonoBehaviour
{
    //    7.(Maior número em uma lista) Dada uma lista de números,
    //      encontre o maior valor.

    int[] numeros = { -3, -5, -2, -12, -21, -96, -87, -7, -9, -10 };
    int maior = 0;
    void Start()
    {
        maior = numeros[0];

        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }

            print("O maior numero é " + maior);
        }
    }

    void Update()
    {
        
    }
}

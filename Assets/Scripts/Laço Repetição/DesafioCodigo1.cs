using UnityEngine;

public class DesafioCodigo1 : MonoBehaviour
{
    //  Escreva um programa que conta o número de consoantes em uma string.

    [SerializeField] string texto = "Jogos digitais";
    [SerializeField] int contadorConsoantes = 0;

    void Start()
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains (letra) || "bcdfghjklmnpqrstvwxyz".ToUpper().Contains(letra))
            {
                contadorConsoantes++;
            }
        }

        print("O numero de consoantes é " + contadorConsoantes);

    }

    void Update()
    {
        
    }
}

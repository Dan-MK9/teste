using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    //    8. (Reverter uma string) Escreva um programa que inverte uma
    //       string usando um loop for.

    string palavra = "Ao vento: ";
    string invertida = "";
    void Start()
    {
        for (int i = palavra.Length -1; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        print("String invertida " +  invertida);
    }

    void Update()
    {
        
    }
}

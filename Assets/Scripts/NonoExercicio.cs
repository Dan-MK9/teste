using System;
using Unity.VisualScripting;
using UnityEngine;

public class NonoExercicio : MonoBehaviour
{
    //    9. (Placar final) Crie um script que l� o placar de uma partida entre
    //       time A e time B.Depois, escreva no console qual dos tr�s
    //       resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
    //       ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //       escreva que foi �um empate emocionante�.

    [SerializeField] int timeA = 1;

    [SerializeField] int timeB = 2;
    void Start()
    {
        if (timeA > timeB)
        {
            print("Vit�ria do time A");
        }
        else if (timeA < timeB)
        {
            print("Vit�ria do time B");
        }
        else
        {
            if (timeA > 3 && timeB > 3)
            {
                print("Foi um empate emocionante!");
            }
            else
            {
                print("Empate");
            }
        }
    }

    void Update()
    {
        
    }
}

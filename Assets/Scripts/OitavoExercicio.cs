using System;
using Unity.Collections;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class OitavoExercicio : MonoBehaviour
{
    //   8. (Contador de horas e dias) Crie um script que em que uma
    //      vari�vel inteira hora seja incrementada de uma unidade a cada 10
    //      segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
    //      completar um ciclo, incremente uma vari�vel dias e escreva o
    //      n�mero de dias que se passaram no console. (Coloque o c�digo
    //      dentro da fun��o-evento Update).

    [SerializeField] int segundos,hora,dia;
    void Start()
    {
        
    }

    void Update()
    {
        segundos++;
        if (segundos % 60==0)
        {
            segundos = 0;
            hora++;
            print(hora);

        if (hora == 24)
            {
                hora = 0;
                dia++;
                print(dia);
            }
        }
    }
}

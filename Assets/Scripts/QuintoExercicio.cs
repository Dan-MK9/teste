using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class QuintoExercicio : MonoBehaviour
{
    //  5. (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    //      recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //      exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //      incompleta".

    [SerializeField] int pontos = 0;

    void Start()
    {
        if (pontos > 50)
        {
            print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    void Update()
    {
        
    }
}

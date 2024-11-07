using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class QuartoExercicio : MonoBehaviour
{
    //4. (Verificar item de invent�rio) Um jogador possui itens limitados
    //   no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
    //   Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    //   indispon�vel".

    [SerializeField] int itemInventario = 1;

    // itemInventario 1: Vazio
    // itemInventario 2: Po��o de Vida
    // itemInventario 3: Espada

    void Start()
    {
        switch (itemInventario) {
            case 1:
                print("Espa�o vazio.");
                break;

            case 2:
                print("Po��o de Vida.");
                break;

            case 3:
                print("Espada.");
                    break;
    }
    }
}

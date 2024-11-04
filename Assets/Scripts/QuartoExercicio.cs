using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class QuartoExercicio : MonoBehaviour
{
    //4. (Verificar item de inventário) Um jogador possui itens limitados
    //   no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //   Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //   indisponível".

    [SerializeField] int itemInventario = 1;

    // itemInventario 1: Vazio
    // itemInventario 2: Poção de Vida
    // itemInventario 3: Espada

    void Start()
    {
        switch (itemInventario) {
            case 1:
                print("Espaço vazio.");
                break;

            case 2:
                print("Poção de Vida.");
                break;

            case 3:
                print("Espada.");
                    break;
    }
    }
}

using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class SetimoExercicio : MonoBehaviour
{
    //   7. (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    //      calcular probabilidades e simular a rolagem de dados.Crie um
    //      script em que o usuário defina o número de faces de um dado
    //      (int) e calcule a rolagem de um dado com esse número de faces.
    //      Use a função abaixo para o cálculo: Random.Range (valor_min,
    //      valor_max); (Coloque o código dentro da função-evento Start).

    [SerializeField] int dados = 6;
    void Start()
    {
        int resultado = Random.Range(1, dados);
        print(resultado);
    }

    void Update()
    {
        
    }
}

using UnityEngine;

public class SextoExercicio : MonoBehaviour
{

    //    6. (Escolha de personagem) O jogador pode escolher entre o
    //      personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //      jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //      Mago.

    [SerializeField] bool personagem = true;
    void Start()
    {
        if (personagem == true)
        {
            print("Guerreiro Selecionado");
        } else
        {
            print("Mago Selecionado");
        }

    }

    void Update()
    {
        
    }
}

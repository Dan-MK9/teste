using UnityEngine;

public class PrimeiroExercicio : MonoBehaviour
{
    //    1. (Verificação de pontos de vida) Um personagem perde pontos
    //de vida após uma batalha.Verifique se ele ainda está vivo.Caso
    //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    //contrário, "Game Over".

    int personagemVivo = 1;

    string resultado;
    void Start()
    {
        if (personagemVivo > 0)
        {
            print($"Personagem Vivo{personagemVivo}");
        }
        else
        {
            print("Game Over");
        }

        //    condição ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (personagemVivo > 0) ? "Personagem vivo!" : "Game Over";
    }

    void Update()
    {
        
    }
}

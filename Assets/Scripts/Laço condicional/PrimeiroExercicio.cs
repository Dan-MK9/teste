using UnityEngine;

public class PrimeiroExercicio : MonoBehaviour
{
    //    1. (Verifica��o de pontos de vida) Um personagem perde pontos
    //de vida ap�s uma batalha.Verifique se ele ainda est� vivo.Caso
    //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    //contr�rio, "Game Over".

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

        //    condi��o ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (personagemVivo > 0) ? "Personagem vivo!" : "Game Over";
    }

    void Update()
    {
        
    }
}

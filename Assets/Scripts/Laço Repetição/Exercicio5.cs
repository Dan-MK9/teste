using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    //    5. (Aumento de n�vel de dificuldade) A cada fase completada, a
    //      dificuldade aumenta em 5 pontos.Exiba a dificuldade ap�s cada
    //      fase, em um total de 6 fases.

    [SerializeField] int fase = 0;
    [SerializeField] int dificuldade = 5;

    void Start()
    {
      while (fase <= 5)
        {
            dificuldade += 5;
            print("A dificuldade atual � " + dificuldade);
            fase++;
        }
    }

    void Update()
    {
        
    }
}

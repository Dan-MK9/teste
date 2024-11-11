using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    //    5. (Aumento de nível de dificuldade) A cada fase completada, a
    //      dificuldade aumenta em 5 pontos.Exiba a dificuldade após cada
    //      fase, em um total de 6 fases.

    [SerializeField] int fase = 0;
    [SerializeField] int dificuldade = 5;

    void Start()
    {
      while (fase <= 5)
        {
            dificuldade += 5;
            print("A dificuldade atual é " + dificuldade);
            fase++;
        }
    }

    void Update()
    {
        
    }
}

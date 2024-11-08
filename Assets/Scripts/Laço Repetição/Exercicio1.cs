using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    //1. (Contagem regressiva de tempo) Crie uma contagem
    //  regressiva de 5 a 1 e exiba "Início da partida!" ao final.

    int segundos = 5;
    void Start()
    {
        for (int i = 0; i <= 5; i++) 
        {
            if (segundos == 0)
            {
                print("Partida iniciada");
            }
            else 
            {
                print(segundos);
                segundos--;
            }
        }

    }

    void Update()
    {
        
    }
}

using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    //    3. (C�lculo de moedas coletadas) O jogador coleta 3 moedas a
    //       cada fase.Ap�s 10 fases, exiba o total de moedas coletadas.

    [SerializeField] int moeda = 0;
    void Start()
    {
        for (int i = 0; i < 9; i++) {
            moeda += 3;
            print($"Moeda coletadas {moeda}");
        }
    }

    void Update()
    {
        
    }
}


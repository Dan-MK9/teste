using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    //  4.  (Pontua��o em combos) Cada combo realizado aumenta em 10
    //      pontos.Exiba a pontua��o total ap�s 7 combos.

    [SerializeField] int pontos = 0;
    [SerializeField] int combo = 0;
    void Start()
    {
        while (combo <= 6)
        {
            print("Os pontos somados s�o " + pontos + " at� agora");
            pontos += 10;
            combo++;
        }
    }

    void Update()
    {
        
    }
}

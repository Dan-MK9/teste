using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    //  4.  (Pontuação em combos) Cada combo realizado aumenta em 10
    //      pontos.Exiba a pontuação total após 7 combos.

    [SerializeField] int pontos = 0;
    [SerializeField] int combo = 0;
    void Start()
    {
        while (combo <= 6)
        {
            print("Os pontos somados são " + pontos + " até agora");
            pontos += 10;
            combo++;
        }
    }

    void Update()
    {
        
    }
}

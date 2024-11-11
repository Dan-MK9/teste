using Unity.VisualScripting;
using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    //2. (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //    dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //    ataque.
    [SerializeField] int ataques = 5;
    [SerializeField] int dano = 10;
    void Start()
    {
        while (ataques > 0)
        {
            print("Voce deu um ataque de " + dano + " de dano");
            dano += 2;
            ataques--;
        }
    }

    void Update()
    {
        
    }
}

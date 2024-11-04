using UnityEngine;

public class TerceiroExercicio : MonoBehaviour
{

    [SerializeField] bool powerUp = true;
    [SerializeField] double vida = 100;
    [SerializeField] double vidaAtual = 100;
    void Start()
    {
        if (vidaAtual <= 0 && powerUp == true)
        {
            vidaAtual = vida * 0.5;
            print("Ainda não, vida atual" + vida);
        } else if (powerUp == false)
        {
            print("Game Over");
        }
    }

    void Update()
    {

    }

}


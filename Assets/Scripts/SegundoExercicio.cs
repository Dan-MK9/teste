using UnityEngine;

public class SegundoExercicio : MonoBehaviour
{
    //    2. (Detecção de power-up) Ao coletar um power-up, o
    //personagem aumenta sua velocidade.Se o jogador encontrar um
    //power-up, exiba "Power-up Coletado". Caso contrário, exiba
    //"Nenhum power-up encontrado".

    [SerializeField] bool powerUp;
    void Start()
    {
        if (powerUp == false)
        {
            print("PowerUp coletado");
        }else
        {
            print("Nenhum PowerUp encontrado");
        }

        // condição ? caso verdade : caso falso
        print((powerUp == false ? "PowerUp Coletado" : "Nenhum PowerUp encontrado"));
    }

    void Update()
    {
        
    }
}

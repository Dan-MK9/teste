using System.Diagnostics;
using UnityEngine;
using static UnityEditor.Progress;

public class DecimoExercicio : MonoBehaviour
{
    //10. (Itens do inventário) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, poções, ou power-ups)
    //que têm efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.

    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pocao = false;
    void Start()
    {
        switch (tipoItem)
        {
            case "Moeda":
                print("Moeda coletada" + moeda);
                break;

            case "Escudo":
                escudo = true;
                print("Escudo Ativo");
                break;

            case "Poção":
                pocao = true;
                print("Poção de vida coletada");
                break;
        }
    }

    void Update()
    {
        
    }
}

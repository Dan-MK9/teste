using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    [SerializeField] bool pocaoVida = false;

    void Start()
    {
        switch (tipoItem)
        {
            case "Moeda":
                moeda++;
                print("Moeda Coletada" + moeda);
                break;

            case "Escudo":
                escudo = true;
                print("Escudo Ativo");
                break;

            case "Poção":
                pocaoVida = true;
                print("Poção de Vida Coletada");
                break;

            default:
                Debug.Log("Item desconhecido!");
                break;
        }
    }

    void Update()
    {
        
    }
}

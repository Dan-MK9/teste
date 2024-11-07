using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class DecimoPrimeiroExercicio : MonoBehaviour
{
    //11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC(personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int estado;
    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Vai Corinthians");
                break;
            case 2:
                print("Hala Madrid");
                break;

            case 3:
                print("Cade meu aumento ?");
                break;

            case 4:
                print("Como vai?");
                break;

            case 5:
                print("Hoje esta chovendo, cuidado");
                break;

            default:
                print("Não tenho nada a dizer sobre isso!");
                break;
        }
    }

    void Update()
    {
        
    }
}

using UnityEngine;

public class Geral : MonoBehaviour
{

    int vidaJogador = 10;

    float velocidadeCarro = 125.5f;

    string nomeJogador = "Michael Jackson";

    char apelido = 'M';

    bool vivo = true;

    int vida_Joogador;



    void Start()
    {
        Debug.Log(vidaJogador);

        print(velocidadeCarro);

        print(vivo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

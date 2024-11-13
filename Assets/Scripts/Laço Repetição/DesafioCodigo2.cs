using System;
using Unity.VisualScripting;
using UnityEngine;

public class DesafioCodigo2 : MonoBehaviour
{

    //  Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu, imprima na tela quantos anos,
    //  meses e dias essa pessoa já viveu.Leve em consideração o ano com 365 dias e o mês com 30 dias.

    [SerializeField] int dia = 0;
    [SerializeField] int mes = 0;
    [SerializeField] int ano = 0;

    void Start()
    {
        int diaAtual = DateTime.Now.Day;
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        //int anosVividos = anoAtual - ano;
        //int mesesVividos = mesAtual - mes;

        //if (mesesVividos < 0)
        //{
        //    anosVividos --;
        //    mesesVividos += 12;
        //}

        //int diasVividos = diaAtual - dia;

        //if (diasVividos < 0)
        //{
        //    mesesVividos --;
        //    diasVividos += 30;
        //    if (diasVividos < 0)
        //    {
        //        anosVividos --;

        //        mesesVividos += 12;
        //    }
        //}

        //print("Voce viveu: " + diasVividos + " dias, " + mesesVividos + " meses, " + "e " + anosVividos + " anos");

        int totalDiasVividos = (anoAtual - ano) * 365 + (mesAtual - mes) * 30 + (diaAtual - dia);

        int anosVividos = totalDiasVividos / 365;
        int mesesVividos = (totalDiasVividos % 365) / 30;
        int diasVividos = (totalDiasVividos % 365) % 30;

        print("Voce viveu: " + diasVividos + " dias, " + mesesVividos + " meses, " + "e " + anosVividos + " anos");
    }

    void Update()
    {
        
    }
}

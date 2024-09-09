using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Aluna: Madu
//Data:09/05/2022
//Objetivo: Reajustar a execução da troca de textos durante a declaração de valores;

public class TrocaTransacao : MonoBehaviour
{
    public GameObject Dinheiro; //texto do R$
    public GameObject plhold; //PlaceHolder dentro do InputField

    public void trocando() //método para ativar um ou outro //valor ao mudar
    {
        if(plhold.GetComponent<Text>().text == "" || plhold.GetComponent<Text>().enabled == false) //ou vazio ou desativado
        {
            Dinheiro.GetComponent<Text>().enabled = true; //Ativa o texto R$
        }

    }

    public void Digitado() //condição para desativar o R$ e voltar para o PlaceHolder //resetando na inspector
    {
        if(plhold.GetComponent<Text>().enabled == true) //ativado
        {
            Dinheiro.GetComponent<Text>().enabled = false; //retira o texto R$
        }
    }
}

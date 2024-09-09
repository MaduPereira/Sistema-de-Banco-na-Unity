using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Importando a biblioteca dos objetos
using System.Text.RegularExpressions; //Importando a biblioteca do texto
using UnityEngine.SceneManagement; //Importando a biblioteca de gerenciamento das Scenes in Build

public class Extrato : MonoBehaviour
{
    public GameObject Texto;
    int numero;

    // Start is called before the first frame update
    void Start()
    {
        GameObject model = Instantiate(Texto) as GameObject;
        model.transform.SetParent(Texto.transform.parent, false);
        model.GetComponent<Text>().text = string.Join("\n", Bank.operacoes);
        model.AddComponent<Text>();
        model.name = "op" + numero;
        numero++;

        // "", "Sacou: R$", Bank.saque, "\nDepositou: R$", Bank.depo
    }

    public void voltar()
    {
        SceneManager.LoadScene("Perfil");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Importando a biblioteca dos objetos
using System.Text.RegularExpressions; //Importando a biblioteca do texto
using UnityEngine.SceneManagement; //Importando a biblioteca de gerenciamento das Scenes in Build


public class cotcad : MonoBehaviour
{
    [SerializeField]
    private GameObject ModeloText;
    private int numero = 1;
    

    void Start()
    {
        // Bank.TotalSaldo[Login.Index] = Bank.saldinho;
        GameObject item = Instantiate(ModeloText) as GameObject;
        item.transform.SetParent(ModeloText.transform.parent, false);
        Registrar.usuario.Add("");
        item.GetComponentInChildren<Text>().text = string.Join (" Saldo: "+Bank.saldinho+ "\n",Registrar.usuario);
        item.AddComponent<Text>();
        item.name = "cad" + numero;
        numero++;
        Debug.Log(Bank.TotalSaldo);
    }

    public void Sair()
    {
        SceneManager.LoadScene("Inicio");  //forma de puxar uma cena ao clicar no Button que vai receber esse m�todo
    }

  
   
}

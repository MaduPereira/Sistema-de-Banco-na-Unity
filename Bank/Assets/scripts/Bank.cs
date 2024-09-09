using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importando a biblioteca de gerenciamento das cenas
// using UnityEngine.UIElements; //Importando a biblioteca dos objetos
// using System.Text.RegularExpressions; //Importando a biblioteca do texto
// using System;

public class Bank : MonoBehaviour
{
    public string nomeDaCena;

    // public GameObject Usuario;
    // private string user;

    public void voltar(){
        SceneManager.LoadScene(nomeDaCena);
    }

    public void registro(){
        SceneManager.LoadScene(nomeDaCena);
    }

    public void sair(){
        Application.Quit();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // user = Usuario.GetComponent<InputField>().text;
    }
}

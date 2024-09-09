using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importando a biblioteca de gerenciamento das Scenes in Build
using UnityEngine.UI; //Importando a biblioteca dos objetos
using System.Text.RegularExpressions; //Importando a biblioteca do texto
using System;

//Aluna: Madu
//Data:09/05/2022
//Objetivo: Fazer o armazenamento de dados para efetuar um login; Apresentar na Interface o feedback;

public class Registrar : MonoBehaviour
{
    public GameObject Usuario2; //declarando objetos em cena que vão ser conectados
    public GameObject Senha2;  //declarando objetos em cena que vão ser conectados
    public GameObject Confsenha2; //declarando objetos em cena que vão ser conectados

    public static string registerUser; //variável static para armazenar e tranferir o usuario para outras cenas
    public static string registerPass; //variável static para armazenar e tranferir a senha para outras cenas
    public static string registerConfirm; //variável static para armazenar e tranferir a validaçao da senha para outras cenas
    
    public Text AvisoIN; //caixa de texto para avisar a condição de erro
    public Text AvisoVa; //caixa de texto para avisar a condição de válido

    public static List<string> usuario = new List<string>();
    public static List<string> codigo = new List<string>();


    public void RegistrarButton(){ //método para armazenar os dados e registar 
        registerUser = Usuario2.GetComponent<InputField>().text; //passando o dado do InputField para a variável compartilhada de usuario

        /*registerUser = Usuario2.transform.Find("Text").gameObject.GetComponent<Text>().text;*/

        registerPass = Senha2.GetComponent<InputField>().text; //passando o dado do InputField para a variável compartilhada de senha
        registerConfirm = Confsenha2.GetComponent<InputField>().text; //passando o dado do InputField para a variável 


        if ((registerPass == registerConfirm)&&(registerUser!="")&&(registerPass!="")&&(!usuario.Contains(registerUser))){ //fazendo tratamento de erro 

            usuario.Add(registerUser);
            codigo.Add(registerPass);
            Bank.TotalSaldo.Add(0);

            AvisoIN.enabled = false; //não transmite o aviso
            StartCoroutine("Avisotempo"); //aciona o método de tempo

        } 
        else
        {
            AvisoIN.enabled = true; //condição para a caixa de texto aparecer 
            AvisoVa.enabled = false; //não transmite o aviso
        }


    }
    IEnumerator Avisotempo(){ //método para fazer um timer
        AvisoVa.enabled = true; //condição para a caixa de texto aparecer
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Inicio");  //forma de puxar uma cena

    }
    public void voltar() 
    {
        SceneManager.LoadScene("Inicio");  //forma de puxar uma cena ao clicar no Button que vai receber esse método
    }

}

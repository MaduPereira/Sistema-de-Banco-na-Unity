using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importando a biblioteca de gerenciamento das Scenes in Build
using UnityEngine.UI; //Importando a biblioteca dos objetos
using System.Text.RegularExpressions; //Importando a biblioteca do texto
using System;

//Aluna: Madu
//Data:09/05/2022
//Objetivo: Fazer as operações do banco de saque e depósito; Mostrar na interface o meu usuário cadastrado; Apresentar na Interface o feedback;

public class Bank : MonoBehaviour
{
    public static string caixauser; //variável que vai receber o usuário de uma variavel static string

    public GameObject Saldo; //declarando objeto em cena que vai ser conectados
    public GameObject Valor; //declarando objeto em cena que vai ser conectados
    public GameObject Pessoa; //declarando objeto em cena que vai ser conectado ao caixauser

    private float valor; //variável para receber meu GameObject Valor
    private  float saldo; //variável para receber a variável valor

    public GameObject Aviso; //caixinha de texto avisando o tempo de inatividade //declarando objetos em cena que vão ser conectados

    public static string saque;
    public static string depo;

    public static float saldinho;

    public static List<string> operacoes = new List<string>();
    public static List<float> TotalSaldo = new List<float>();

    public void sacar(){ //método para efetuar o saque
        
        
        valor = float.Parse(Valor.GetComponent<InputField>().text); //usei o float.Parse para transformar o Valor de string para float possibilitando as operações 
        if(valor <= saldo && valor > 0){ //fazendo o tratamento de erro

            // TotalSaldo[Login.Index] -= valor;
            // Debug.Log(TotalSaldo[0] + TotalSaldo[1]);
            saldo -= valor;
            Debug.Log("voce sacou " +Valor.transform.Find("Text").gameObject.GetComponent<Text>().text); //teste
            Saldo.GetComponent<InputField>().text = saldo.ToString(); //usei o .ToString para transformar saldo em string possibilitando o Input Saldo exibir os valores 
            saldinho = saldo;
            saque = Valor.GetComponent<InputField>().text;
            operacoes.Add("-" + saque);
            Debug.Log(operacoes);
            int i = Registrar.usuario.LastIndexOf(""); 
            if(Registrar.usuario[i] == "")
            {
                Registrar.usuario.RemoveAt(i);
            }
            TotalSaldo.Insert(Login.Index,saldinho);
        }    

    }

    public void depositar(){ //método para efetuar o depósito
        
        valor = float.Parse(Valor.GetComponent<InputField>().text);//usei o float.Parse para transformar o Valor de string para float possibilitando as operações 
        if(valor > 0){     //fazendo o tratamento de erro
            saldo += valor;
            Debug.Log("vc depositou " +Valor.transform.Find("Text").gameObject.GetComponent<Text>().text); //teste
            Saldo.GetComponent<InputField>().text = saldo.ToString(); //usei o .ToString para transformar saldo em string possibilitando o Input Saldo exibir os valores
            saldinho = saldo;
            depo = Valor.GetComponent<InputField>().text;
            operacoes.Add("+" + depo);
            Debug.Log(operacoes);
            int i = Registrar.usuario.LastIndexOf(""); 
            if(Registrar.usuario[i] == "")
            {
                Registrar.usuario.RemoveAt(i);
            }
            TotalSaldo.Insert(Login.Index,saldinho);

        }
    }

    IEnumerator IniciarCoroutine() //método para fazer um timer
    {
        yield return new WaitForSeconds(5); //definindo os segundos
        Aviso.SetActive(true); //para ativar a caixa de texto
        yield return new WaitForSeconds(10); //definindo os segundos
        SceneManager.LoadScene("Inicio");

    }

    public void umacliclada()  //método para resetar o time já feito se o usuário reclicou na tela
    {
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine("IniciarCoroutine"); //pause no tempo
            Aviso.SetActive(false);
            StartCoroutine("IniciarCoroutine"); //star no tempo
        }
    }

    public void extra()
    {
        SceneManager.LoadScene("Extrato");
    }

    public void sair()
    {
        SceneManager.LoadScene("Inicio");
    }
    
    void Update()
    {
        umacliclada(); //aqui eu starto o meu método de tempo
        caixauser=Login.usuarioReceb; //aqui no update pois o user pode ser alterado com um novo cadastro
        Pessoa.GetComponent<Text>().text = caixauser;
    }

    void Start()
    {
        Saldo.GetComponent<InputField>().text = saldinho.ToString();
    }
}

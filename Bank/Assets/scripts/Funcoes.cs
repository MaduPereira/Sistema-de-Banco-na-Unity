using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //Importando a biblioteca dos objetos
using System.Text.RegularExpressions; //Importando a biblioteca do texto
using System;

public class Funcoes : MonoBehaviour
{
    public string nomeDaCena;
    
    public GameObject Usuario2; //nomes dos objetos em cena
    public GameObject Senha2;
    public GameObject Confsenha2;

    [SerializeField]
    private InputField Usuario1; //puxando o objeto de texto da cena
    [SerializeField]
    private InputField Senha1;
    

    private string user; //definindo um valor vaziu para ser substituído
    private string pass;
    private string confirm; //variável de verificação
    
    public void RegistrarButton(){
        user = Usuario2.GetComponent<InputField>().text; //passando o texto para a variável
        pass = Senha2.GetComponent<InputField>().text;
        confirm = Confsenha2.GetComponent<InputField>().text;

        if (Senha2.GetComponent<InputField>().text == Confsenha2.GetComponent<InputField>().text){
            Debug.Log("Usuário registrado com sucesso, volte e faça login");
            SceneManager.LoadScene(nomeDaCena);

        }else {
            Debug.Log("Erro");
        }

    }

    // delegate void substitui();
    // substitui variavelsub;

    public void AutentificaLogin(){
        user = Usuario2.GetComponent<InputField>().text;
        pass = Senha2.GetComponent<InputField>().text;

        if ((user ==  Usuario1.text)&&(pass == Senha1.text)){
            Debug.Log("Usuário Válido");
            SceneManager.LoadScene(nomeDaCena);

        }else {
            Debug.Log("Usuário Inválido");
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // variavelsub = RegistrarButton;
    }
}

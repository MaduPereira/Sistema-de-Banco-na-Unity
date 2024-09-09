 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Importando a biblioteca dos objetos
using UnityEngine.SceneManagement; //Importando a biblioteca de gerenciamento das Scenes in Build

//Aluna: Madu
//Data:09/05/2022
//Objetivo: Fazer a validação do login de um usuário cadastrado; Apresentar na Interface o feedback;

public class Login : MonoBehaviour
{
    string user; //variável declarada para receber o valor de usuário da scene Cadastro
    string pass; //variável declarada para receber o valor de senha da scene Cadastro
    public static string usuarioReceb, senhaReceb; //variáveis para receber o valor do imput de usuario1 e senha1
    public InputField Usuario1, Senha1; //recebendo os textos dos Inputs da cena 
    public Text loginIN; //caixa de texto para avisar a condição de erro
    public Text loginVa; //caixa de texto para avisar a condição de válido

    [SerializeField]
    private GameObject lista;
    [SerializeField]
    private GameObject so;


    public static int Index;

    public void AutentificaLogin() //método para validar a entrada de dados registrados
    {
        user = Registrar.registerUser; //user recebe o valor do usuario registrado no script Registrar //forma de receber uma informação de uma cena para outra
        pass = Registrar.registerPass; //pass recebe o valor da senha registrada no script Registrar 

        Registrar.usuario.Contains(user);
        Registrar.codigo.Contains(pass);

        usuarioReceb = Usuario1.text; //fazendo com que minha variável receba o Input de usuario1
        senhaReceb = Senha1.text; //fazendo com que minha variável receba o Input de senha1

        foreach (string uso in Registrar.usuario)
        {
            if(uso.Equals(usuarioReceb)) 
            {
                Index = Registrar.usuario.IndexOf(uso);

                if((Registrar.codigo[Index].Equals(senhaReceb)&& (usuarioReceb != "") && (senhaReceb != "")))
                {
                    loginIN.enabled = false; //não transmite o aviso
                    StartCoroutine("Avisotempo"); //aciona o método de tempo
                }
                else
                {
                    loginIN.enabled = true; //condição para a caixa de texto aparecer 
                    loginVa.enabled = false; //não transmite o aviso
                
                }

            }
        }

        if((usuarioReceb=="Madu")&&(senhaReceb =="1234")){ //login ADM

            lista.SetActive(true);
            so.SetActive(true);
            loginVa.enabled = true;
        }

    }

    public void Controle()
    {
        SceneManager.LoadScene("Controle");
    }

    IEnumerator Avisotempo(){ //método para fazer um timer
        loginVa.enabled = true; //condição para a caixa de texto aparecer
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Perfil"); //forma de puxar uma cena
    }

    public void registro() 
    {
        SceneManager.LoadScene("Cadastro"); //forma de puxar uma cena ao clicar no Button que vai receber esse método
    }
    public void Sair()
    {
        Application.Quit(); //forma de puxar uma cena ao clicar no Button que vai receber esse método
    }
}

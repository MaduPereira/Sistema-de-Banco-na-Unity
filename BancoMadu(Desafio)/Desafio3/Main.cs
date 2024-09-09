using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Main : MonoBehaviour
{
    void CriaTexto()
    {
        string path = Application.dataPath + "/Log.txt";
        if(!File.Exists(path))
        {
            File.WriteAllText(path, "Login log \n\n");
        }

        string content = "Login date: " + System.DateTime.Now + " Usuário: " + Bank.caixauser + " Saldo: " + Bank.saldinho + "\n";
        string dados = string.Join("\n", Bank.operacoes);
        File.AppendAllText(path, content + dados);
    }
    // Start is called before the first frame update
    void Start()
    {
        CriaTexto();
    }
}

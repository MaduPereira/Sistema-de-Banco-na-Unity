using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorcad : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.parent.GetComponent<Registrar>().RegistrarButton();
    }
}

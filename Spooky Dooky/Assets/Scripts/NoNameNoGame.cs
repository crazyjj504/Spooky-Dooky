using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoNameNoGame : MonoBehaviour
{


    public GameObject wall;
    public GameObject NameKeyboard;
    public string Name;

    void Update()
    {
        if (NameKeyboard != null)
        {
            Name = NameKeyboard.GetComponent<NameScript>().NameVar;

            if (string.IsNullOrEmpty(Name)) 
            {
                wall.SetActive(true);
            }
            else
            {
                wall.SetActive(false);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Naveen;

public class MenuScreen : MonoBehaviour
{
    public GameObject[] panels;

    private void Start()
    {
        ActivatePanel("Main");
        AudioManager.instance.Play("MainTheme");
        
    }

    public void ActivatePanel(string name)
    {
        foreach (var g in panels)
        {
            g.SetActive(name.Equals(g.name));
        }
    }

    public void SelectLevel(string l)
    {
        SceneManager.LoadScene(l);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public UnityEngine.UI.Text puan;
    // Start is called before the first frame update
    void Start()
    {
        puan.text = "Puan " + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().PuaniAl();
    }

    public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
}

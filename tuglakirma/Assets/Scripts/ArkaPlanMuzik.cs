using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanMuzik : MonoBehaviour
{
    static bool SahnedeMuzikVar = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!SahnedeMuzikVar)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            SahnedeMuzikVar = true;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

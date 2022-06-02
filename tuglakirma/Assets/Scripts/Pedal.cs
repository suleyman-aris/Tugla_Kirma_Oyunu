using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    private GameObject top;
    // Start is called before the first frame update
    void Start()
    {
        top = GameObject.Find("top");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(Mathf.Clamp(farePos.x,-3,3), transform.position.y, transform.position.z);
        //transform.position = new Vector3(top.transform.position.x, transform.position.y, transform.position.z);
    }
}

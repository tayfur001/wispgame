using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mekan: MonoBehaviour
{

    public bool temasAlan;
    public GameObject Alan;
    private const string Message = "temas edildi";

    // Use this for initialization
    void Start()
    {
        temasAlan = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (temasAlan)
        {
            AtaP();
            temasAlan = false;
        }

    }

    void AtaP()
    {
        Alan.transform.position = transform.position + new Vector3(39.48f, 0, 0);
    }
}
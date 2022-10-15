using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rebuilding : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter2D(Collider2D temass)
    {
        if (temass.gameObject.tag == "toz")
        {
            temass.gameObject.transform.GetComponent<moondust>().rebuildDust = true;
        }
        if (temass.gameObject.tag == "alan")
        {
            temass.gameObject.transform.GetComponent<mekan>().temasAlan = true;
        }


    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alanagac : MonoBehaviour {

    public GameObject player;
    public float ilerleme;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ilerleme = player.gameObject.transform.GetComponent<player>().speed;
        transform.Translate(Vector2.right * ilerleme * 0.3f * Time.deltaTime);
    }
}

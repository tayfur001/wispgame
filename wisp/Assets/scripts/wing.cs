using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.gameObject.transform.position.x, player.gameObject.transform.position.y, 1);
    }
}

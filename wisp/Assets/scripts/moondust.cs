using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moondust : MonoBehaviour {

    public bool temasDust;
    public bool rebuildDust;
    public GameObject moonD;
    //public Sprite toz;
    private Animator animator;
    
    //private SpriteRenderer sprite;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        //sprite = GetComponent<SpriteRenderer>();
        temasDust = false;
        rebuildDust = false;

    }
	
	// Update is called once per frame
	void Update () {

        if (temasDust)
        {
            animator.SetTrigger("patlama");


        }

        if (rebuildDust)
        {
            rebuildD();
            
            //sprite.sprite = toz;
            rebuildDust = false;
            

        }
	}

    void rebuildD()
    {
        float yPoz = Random.Range(-3, 3);
        float xPoz = Random.Range(40, 50);
        moonD.transform.position = transform.position + new Vector3(xPoz, yPoz, 0);
        animator.SetTrigger("rebuild");
        temasDust = false;

    }
}

using UnityEngine;
using System.Collections;

public class doorscript2 : MonoBehaviour {

    public Animator anim;


	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Open()
    {
        anim.SetBool("opened", true);

    }

    public void Close()
    {
        anim.SetBool("opened", false);

    }

    void OnTriggerEnter( Collider col)
    {
        if(col.tag == "Player")
        {
            Open();

        }

    }

    void OnTriggerExit (Collider col)
    {
        if(col.tag == "Player")
        {
            Close();

        }

    }

}

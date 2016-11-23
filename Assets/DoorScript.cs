using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Open()
    {

        anim.SetBool("open", true);


    }

    public void Close()
    {

        anim.SetBool("open", false);

    }


    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player") Open();

    }


    void OnTriggerExit(Collider col)
    {

        if (col.tag == "Player") Close();

    }

}

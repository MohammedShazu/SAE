using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    GameManager gm;
    float h, v;
    public float jumpForce, moveSpeed, rotateSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
                
        //if the game manager exists, get a reference to it and store it in the variable gm
        if(GameManager.instance != null)      gm = GameManager.instance;
	}
	
	// Update is called once per frame
	void Update () {


        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //transform.Translate(new Vector3(h, 0, v) * moveSpeed * Time.deltaTime);

        transform.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);

        transform.Rotate(new Vector3(0, h * rotateSpeed * Time.deltaTime, 0));


        //
        //
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce);
            
        }


        

	}

    public void OnCollisionEnter(Collision col)
    {

        if(col.gameObject.tag == "Enemy")
        {
            //
            gm.AddToScore(1);
            Destroy(col.gameObject, 1);
        }

    }

    public void LoadLevel1()
    {

        //Load the 1st scene
        SceneManager.LoadScene(0);
    }

    public void LoadLevel2()
    {

        //Load the 1st scene
        SceneManager.LoadScene(1);
    }
}

using UnityEngine;
using System.Collections;

public class fadeout : MonoBehaviour {

    public float value = 1.0f;
    public Material m, m2;
    public bool started = false;
    MeshRenderer r;

    // Use this for initialization
    void Start () {
        //create a new material based off the existing one.
        m2 = new Material(m);
        r = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (started)
        {

            //set the new colour
            m2.color = new Color(m.color.r, m.color.g, m.color.b, value);

            //
            r.material = m2;
            
            //change it: minus 0.005
            if (value >= 0.0f) value -= 0.005f;

        }


	}

    public void StartGame()
    {
        started = true;

    }


}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int score;

    public bool candleStick;
    public int keys;


    public static GameManager instance = null; //Static instance of GameManager which allows it to be accessed by any other script.

    void Awake()
    {

        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }
        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Score is " + score.ToString());

        

    }

    public void AddToScore(int i)
    {
        score += i;


    }

    

}

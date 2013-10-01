using UnityEngine;
using System.Collections;

public class CollectTrigger : MonoBehaviour 
{
    public static int score = 0;
    public int value;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

    }
    void OnTriggerEnter(Collider other)
        {
        Destroy(gameObject);
        score++;
        }
    void OnCollisionEnter(Collision other)
	{
        Destroy(gameObject);
        score++;
    }
}



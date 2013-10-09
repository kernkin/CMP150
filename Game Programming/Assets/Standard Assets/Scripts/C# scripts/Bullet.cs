using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
    public float Speed;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 

    {
        transform.Translate(transform.InverseTransformDirection(transform.forward) * Speed * Time.deltaTime, Space.Self);
	}
}

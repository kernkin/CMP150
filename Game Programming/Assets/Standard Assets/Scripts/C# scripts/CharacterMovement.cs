using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * (moveSpeed * Time.deltaTime));
        }
    }
}

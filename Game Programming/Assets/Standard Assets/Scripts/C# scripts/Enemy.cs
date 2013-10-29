using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
    public int maxHealth = 1; 
    public int curHealth = 1;

    void Start () 
    { 

    }
    void Update () 
    { 
    if (curHealth <1)
        { 
            Destroy(gameObject); 
        } 
    }

   /* void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            curHealth -= 20;
            Destroy(col.other);
        }
    }*/
        
    public int life = 0;
         
    public void OnCollisionEnter(Collision boom) 
    {
        //If the object that triggered this collision is tagged "bullet"
        if(boom.gameObject.tag == "bullet")
        {
               life +=1;
               if(life == 50)
               Destroy(gameObject);
        }
    }
    
} 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*public int maxHealth = 100;
    public int curHealth = 100;

    public float healthBarLength;

    // Use this for initialization 
    void Start()
    {
        healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame 
    void Update()
    {
        AdjustCurrentHealth(0);
    }

    void OnGUI()
    {

        GUI.Box(new Rect(10, 40, healthBarLength, 20), curHealth + "/" + maxHealth);

    }


    public void AdjustCurrentHealth(int adj)
    {
        curHealth += adj;

        if (curHealth < 0)
            curHealth = 0;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;

        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);


    }
} */



  
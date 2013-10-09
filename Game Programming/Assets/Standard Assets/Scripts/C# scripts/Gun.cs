using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour 
{
    public float bulletSpeed;
    public float fireRate;
    public Bullet Ammo;
    public float reloadSpeed;
    public Control Shoot;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
    void Update()
    {
    if (Shoot.IsActive)
        {
            fire();
        }
    }
    
   



    void fire()
    {
        Bullet bullet = ((Bullet)Instantiate(Ammo, transform.position, transform.rotation));
        bullet.Speed = bulletSpeed;

	}
}

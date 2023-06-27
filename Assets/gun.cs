using UnityEngine;
using System.Collections;

public class gun: MonoBehaviour {

    public GameObject bulletPrefab; // assign this in the inspector
    public float bulletSpeed = 20f; // adjust this as needed
    public Transform firePoint; // assign this in the inspector

    void Start () {
        InvokeRepeating("Shoot", 1f, 1);
    }

    void Shoot () {
        // create a bullet object from the prefab
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation) as GameObject;
        Vector2 direction = firePoint.up;
        // set the bullet's velocity to that direction times the speed
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
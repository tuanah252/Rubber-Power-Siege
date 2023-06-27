using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyed : MonoBehaviour
{
    public GameObject pop;
    public Transform target;
    public GameObject chicken;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("rabbit"))
        {
            Destroy(gameObject);
            Instantiate(pop, transform.position, Quaternion.identity);
            Instantiate(chicken, target.position, Quaternion.identity);
        }
    }
}
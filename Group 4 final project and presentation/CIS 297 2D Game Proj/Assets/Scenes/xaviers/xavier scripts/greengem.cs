using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greengem : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            GameManager.greengem++;
            Destroy(this.gameObject);
        }
    }
}

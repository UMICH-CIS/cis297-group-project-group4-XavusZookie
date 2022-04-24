using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluegem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            GameManager.bluegem++;
            Destroy(this.gameObject);
        }
    }
}

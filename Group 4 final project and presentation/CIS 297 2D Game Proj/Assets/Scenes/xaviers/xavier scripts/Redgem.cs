using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redgem : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            GameManager.redgem++;
            Destroy(this.gameObject);
        }
    }


}

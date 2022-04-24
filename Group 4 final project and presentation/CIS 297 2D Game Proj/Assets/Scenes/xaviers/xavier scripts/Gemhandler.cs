using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gemhandler : MonoBehaviour
{
    public int gemsneeded = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.greengem >= gemsneeded && GameManager.redgem >= gemsneeded && GameManager.bluegem >= gemsneeded)
            loadnextlevel();
    }

    void loadnextlevel()
    {
        SceneManager.LoadScene("Win Scene");

    }
}

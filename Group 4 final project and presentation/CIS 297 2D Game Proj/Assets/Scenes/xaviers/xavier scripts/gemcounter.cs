using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gemcounter : MonoBehaviour
{
    public int prevgreengem = -1;
    public Text greencounter;
    public int prevredgem = -1;
    public Text redcounter;
    public int prevbluegem = -1;
    public Text bluecounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (prevgreengem != GameManager.greengem)
        {
            prevgreengem = GameManager.greengem;
            greencounter.text = "Green Gems " + GameManager.greengem;
        }

        if (prevredgem != GameManager.redgem)
        {
            prevredgem = GameManager.redgem;
            redcounter.text = "Red Gems " + GameManager.redgem;
        }

        if (prevbluegem != GameManager.bluegem)
        {
            prevbluegem = GameManager.bluegem;
            bluecounter.text = "Blue Gems " + GameManager.bluegem;
        }
    }
}

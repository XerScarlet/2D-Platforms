using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mods : MonoBehaviour
{
    [Header("Platforms")]
    public GameObject platform1;
    public GameObject platform2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            platform1.SetActive(true);
            platform2.SetActive(true);
        }

        if (Input.GetKeyUp("e"))
        {
            platform1.SetActive(false);
            platform2.SetActive(false);
        }
    }
}

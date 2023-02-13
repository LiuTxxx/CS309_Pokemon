using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTools : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void changePage(GameObject[] gameObjectList)
    {
        gameObjectList[0].SetActive(false);
        gameObjectList[1].SetActive(true);
    }
}

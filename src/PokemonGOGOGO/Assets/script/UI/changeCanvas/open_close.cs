using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_close : MonoBehaviour
{
    public GameObject[] clickChangeList;
    public GameObject[] pageList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onOpen()
    {
        GameObject buttonClicked = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        int buttonId = int.Parse(buttonClicked.name.Substring(0, 1)) - 1;
        GameObject toOpen = clickChangeList[buttonId];
        openPage(toOpen);
    }

    public void onClose()
    {
        GameObject buttonClicked = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        int buttonId = int.Parse(buttonClicked.name.Substring(0, 1)) - 1;
        GameObject toClose = clickChangeList[buttonId];
        closePage(toClose);
    }

    public static void openPage(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }

    public static void closePage(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

}

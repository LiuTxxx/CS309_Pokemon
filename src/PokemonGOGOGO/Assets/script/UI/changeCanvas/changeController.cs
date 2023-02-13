using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeController : MonoBehaviour
{
    public GameObject[] clickChangeList;
    public GameObject[] followOpenList;
    public GameObject[] followCloseList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        GameObject buttonClicked = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        int buttonId = int.Parse(buttonClicked.name.Substring(0, 1)) - 1;
        GameObject[] changeList = new GameObject[2];
        changeList[0] = this.gameObject;
        changeList[1] = clickChangeList[buttonId];
        changeTools.changePage(changeList);
        followChange(buttonId);
    }

    public void followChange(int i)
    {
        if (followOpenList.Length > i)
        {
            if (followOpenList[i] != null)
            {
                followOpenList[i].SetActive(true);
            }
        }
        if (followCloseList.Length > i)
        {
            if (followCloseList[i] != null)
            {
                followCloseList[i].SetActive(false);
            }
        }  
    }
}

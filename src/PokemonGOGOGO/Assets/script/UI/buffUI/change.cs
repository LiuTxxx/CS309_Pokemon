using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public string change1 = "no";
    public string change2 = "no";
    // Start is called before the first frame update
    void Start()
    {
        change1 = "no";
        change2 = "no";
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Choose()
    {
        GameObject buttonClicked = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        string buttonName = buttonClicked.name;
        
        if (change1.Equals("no") && !change2.Equals(buttonName))
        {
            change1 = buttonName;
            GameObject skill1 = GameObject.Find("Canvas/" + change1);
            RectTransform transform = skill1.GetComponent<RectTransform>();
            transform.sizeDelta = new Vector2(160, 80);
        }
        else if (change1.Equals(buttonName))
        {
            GameObject skill1 = GameObject.Find("Canvas/" + change1);
            RectTransform transform = skill1.GetComponent<RectTransform>();
            transform.sizeDelta = new Vector2(168.42f, 85.59f);
            change1 = "no";
        }
        else if (change2.Equals("no"))
        {
            change2 = buttonName;
            GameObject skill2 = GameObject.Find("Canvas/" + change2);
            RectTransform transform = skill2.GetComponent<RectTransform>();
            transform.sizeDelta = new Vector2(160, 80);
        }
        else if (change2.Equals(buttonName))
        {
            GameObject skill2 = GameObject.Find("Canvas/" + change2);
            RectTransform transform = skill2.GetComponent<RectTransform>();
            transform.sizeDelta = new Vector2(168.42f, 85.59f);
            change2 = "no";
        }

    }


    public void Change()
    {
        GameObject skill1 = GameObject.Find("Canvas/" + change1);
        GameObject skill2 = GameObject.Find("Canvas/" + change2);
        RectTransform transform1 = skill1.GetComponent<RectTransform>();
        RectTransform transform2 = skill2.GetComponent<RectTransform>();
        Vector3 pos = transform1.position;
        transform1.position = transform2.position;
        transform2.position = pos;
        transform1.sizeDelta = new Vector2(168.42f, 85.59f);
        transform2.sizeDelta = new Vector2(168.42f, 85.59f);
        change1 = "no";
        change2 = "no";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fightingBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickSkill()
    {
        GameObject skill = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        Debug.Log(skill.name);
    }

    public void onClickChangePM()
    {
        Debug.Log("change PM");
    }

    public void onClickCheckBuff()
    {
        Debug.Log("check buff");
    }

}

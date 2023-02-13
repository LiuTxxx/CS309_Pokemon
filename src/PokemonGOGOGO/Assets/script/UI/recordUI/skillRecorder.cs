using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillRecorder : MonoBehaviour
{
    private int skill_id;
    private string skill_name;
    private int skill_power;//Õ˛¡¶
    private int skill_shuxing;// Ù–‘

    public skillRecorder(int skill_id, string skill_name)
    {
        this.skill_id = skill_id;
        this.skill_name = skill_name;
    }

    public skillRecorder(int skill_id, string skill_name, int skill_power, int skill_shuxing)
    {
        this.skill_id = skill_id;
        this.skill_name = skill_name;
        this.skill_power = skill_power;
        this.skill_shuxing = skill_shuxing;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string get_skillName()
    {
        return skill_name;
    }
}

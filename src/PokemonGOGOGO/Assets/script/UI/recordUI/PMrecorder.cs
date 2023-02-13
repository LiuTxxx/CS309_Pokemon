using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMrecorder : MonoBehaviour
{
    private int PM_id;
    private string PM_name;
    private string PM_shuxing;//属性
    private int[] PM_pro;//面板数值
    private skillRecorder[] PM_skillList;//可习得技能
    private int[] skill_learningLevel;//按顺序习得技能的等级或进化

    public PMrecorder(int pM_id, string pM_name,string pM_shuxing, int[] pM_pro, skillRecorder[] pM_skillList, int[] skill_learningLevel)
    {
        PM_id = pM_id;
        PM_name = pM_name;
        PM_shuxing = pM_shuxing;
        PM_pro = pM_pro;
        PM_skillList = pM_skillList;
        this.skill_learningLevel = skill_learningLevel;
    }

    public PMrecorder(){}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getPMinfo()
    {
        string result = PM_name + ":" + PM_shuxing + "属性\n";
        result += "生命：" + PM_pro[0] + "\n";
        result += "物攻：" + PM_pro[1] + "\n";
        result += "物防：" + PM_pro[2] + "\n";
        result += "特攻：" + PM_pro[3] + "\n";
        result += "特防：" + PM_pro[4] + "\n";
        result += "速度：" + PM_pro[5] + "\n";
        return result;
    }

    public string getPMskill()
    {
        string result = PM_name + " 技能表：\n";
        int cnt = 1;
        for (int i = 0; i < PM_skillList.Length; i++)
        {
            result += cnt + "." + PM_skillList[i].get_skillName();
            result += "  等级:" + skill_learningLevel[i] + "\n";
            cnt++;
        }
        return result;
    }

    public string getPMname()
    {
        return PM_name;
    }
}

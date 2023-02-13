using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMrecorder : MonoBehaviour
{
    private int PM_id;
    private string PM_name;
    private string PM_shuxing;//����
    private int[] PM_pro;//�����ֵ
    private skillRecorder[] PM_skillList;//��ϰ�ü���
    private int[] skill_learningLevel;//��˳��ϰ�ü��ܵĵȼ������

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
        string result = PM_name + ":" + PM_shuxing + "����\n";
        result += "������" + PM_pro[0] + "\n";
        result += "�﹥��" + PM_pro[1] + "\n";
        result += "�����" + PM_pro[2] + "\n";
        result += "�ع���" + PM_pro[3] + "\n";
        result += "�ط���" + PM_pro[4] + "\n";
        result += "�ٶȣ�" + PM_pro[5] + "\n";
        return result;
    }

    public string getPMskill()
    {
        string result = PM_name + " ���ܱ�\n";
        int cnt = 1;
        for (int i = 0; i < PM_skillList.Length; i++)
        {
            result += cnt + "." + PM_skillList[i].get_skillName();
            result += "  �ȼ�:" + skill_learningLevel[i] + "\n";
            cnt++;
        }
        return result;
    }

    public string getPMname()
    {
        return PM_name;
    }
}

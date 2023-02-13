using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class loadRecordBook : MonoBehaviour
{
    //public static GameObject info_display;
    //public static GameObject skill_display;
    private PMrecorder pmToDisplay;
    //public int displayID = 0;
    //private static PMrecorder[] pmList;
    //private static List<PMrecorder> PMrecorders = new List<PMrecorder>();
    // Start is called before the first frame update
    void Start()
    {
        //string filePath = "./Assets/data/recordBook.txt";
        //StreamReader sr = File.OpenText(filePath);

        //string nextLine;
        //int cnt = 0;
        //while((nextLine = sr.ReadLine()) != null)
        //{

        //    string[] info = nextLine.Split(' ');
        //    int[] pm_pro = new int[6];

        //    for (int i = 0; i < 6; i++)
        //    {
        //        pm_pro[i] = int.Parse(info[3 + i]);
        //    }


        //    skillRecorder[] skill_list = new skillRecorder[(info.Length - 9)/2];
        //    int[] skill_lv = new int[(info.Length - 9) / 2];
        //    int j = 0;
        //    for (int i = 0; i < skill_list.Length; i++)
        //    {
        //        skill_list[i] = new skillRecorder(cnt, info[9 + j]);
        //        skill_lv[i] = int.Parse(info[10 + j]);
        //        j += 2;
        //    }
        //    PMrecorder newPM = new PMrecorder(int.Parse(info[0]), info[1], info[2], pm_pro, skill_list, skill_lv);
        //    PMrecorders.Add(newPM);
        //    //pmList[int.Parse(info[0])] = newPM;
        //}

        //for (int i = 0; i < PMrecorders.Count; i++)
        //{
        //    string pminfo = PMrecorders[i].getPMinfo();
        //    Text text1 = info_display.GetComponent<Text>();
        //    text1.text = pminfo;
        //    string pmskill = PMrecorders[i].getPMskill();
        //    Text text2 = skill_display.GetComponent<Text>();
        //    text2.text = pmskill;
        //}


        //for (int i = 0; i < pmList.Length; i++)
        //{
        //    string pminfo = pmList[i].getPMinfo();
        //    Debug.Log(pminfo);
        //    Debug.Log("get info success");
        //    string pmskill = pmList[i].getPMskill();
        //    Debug.Log(pmskill);
        //    Debug.Log("get skill success");
        //}

        //info_display = GameObject.Find("infoText").gameObject;
        //skill_display = GameObject.Find("skillText").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void displayRecord()
    //{
    //    Debug.Log("start");
    //    string pminfo = pmList[displayID].getPMinfo();
    //    Debug.Log(pminfo);
    //    string pmskill = pmList[displayID].getPMskill();
    //    Debug.Log(pmskill);
    //}

    //public static PMrecorder[] GetPMList()
    //{
    //    return pmList;
    //}

    //private void OnEnable()
    //{
    //    for (int i = 0; i < PMrecorders.Count; i++)
    //    {
    //        string pminfo = PMrecorders[i].getPMinfo();
    //        Text text1 = info_display.GetComponent<Text>();
    //        text1.text = pminfo;
    //        string pmskill = PMrecorders[i].getPMskill();
    //        Text text2 = skill_display.GetComponent<Text>();
    //        text2.text = pmskill;
    //    }
    //}

    public static void displayDetails(PMrecorder pm, GameObject info_display, GameObject skill_display)
    {
        string pminfo = pm.getPMinfo();
        Text text1 = info_display.GetComponent<Text>();
        text1.text = pminfo;
        string pmskill = pm.getPMskill();
        Text text2 = skill_display.GetComponent<Text>();
        text2.text = pmskill;
    }
    private void OnDisable()
    {
        pmToDisplay = new PMrecorder();
    }

}

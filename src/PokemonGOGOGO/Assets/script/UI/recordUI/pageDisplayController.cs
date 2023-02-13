using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class pageDisplayController : MonoBehaviour
{
    public GameObject[] displayList;
    public GameObject recordDetails;
    public GameObject info_display;
    public GameObject skill_display;
    public GameObject pmNameText;
    private int currentPage = 0;
    private static PMrecorder[] pmInfoToDisplay;
    private static List<PMrecorder> PMrecorders = new List<PMrecorder>();

    // Start is called before the first frame update
    void Start()
    {
        string filePath = "./Assets/data/recordBook.txt";
        StreamReader sr = File.OpenText(filePath);

        string nextLine;
        int cnt = 0;
        while ((nextLine = sr.ReadLine()) != null)
        {

            string[] info = nextLine.Split(' ');
            int[] pm_pro = new int[6];

            for (int i = 0; i < 6; i++)
            {
                pm_pro[i] = int.Parse(info[3 + i]);
            }


            skillRecorder[] skill_list = new skillRecorder[(info.Length - 9) / 2];
            int[] skill_lv = new int[(info.Length - 9) / 2];
            int j = 0;
            for (int i = 0; i < skill_list.Length; i++)
            {
                skill_list[i] = new skillRecorder(cnt, info[9 + j]);
                skill_lv[i] = int.Parse(info[10 + j]);
                j += 2;
            }
            PMrecorder newPM = new PMrecorder(int.Parse(info[0]), info[1], info[2], pm_pro, skill_list, skill_lv);
            PMrecorders.Add(newPM);
        }
        pmInfoToDisplay = PMrecorders.ToArray();
        this.onDisplayRecord();
    }

    private void OnEnable()
    {
        //pmInfoToDisplay = loadRecordBook.GetPMList();
        //Debug.Log(pmInfoToDisplay[0].getPMinfo());
        //Debug.Log(pmInfoToDisplay.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickUp()
    {
        currentPage -= 1;
        if (currentPage == -1)
        {
            Debug.Log("this is the first page");
            currentPage += 1;
        }
        else onDisplayRecord();
    }

    public void onClickDown()
    {
        currentPage += 1;
        if (currentPage * displayList.Length >= pmInfoToDisplay.Length)
        {
            Debug.Log("this is the last page.");
            currentPage -= 1;
        }
        else onDisplayRecord();
    }

    public void onDisplayRecord()
    {
        for (int i = 0; i < displayList.Length; i++)
        {
            Text text = displayList[i].GetComponent<Text>();
            if (currentPage * displayList.Length + i < pmInfoToDisplay.Length)
            {
                text.text = pmInfoToDisplay[currentPage * displayList.Length + i].getPMname();
            }
            else text.text = "未发现";
        }
    }

    public void onClickDisplayDetail()
    {
        GameObject buttonClicked = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        int buttonId = int.Parse(buttonClicked.name.Substring(7, 1)) - 1;
        if (buttonId + currentPage * displayList.Length < pmInfoToDisplay.Length)
        {
            string pminfo = pmInfoToDisplay[buttonId + currentPage * displayList.Length].getPMinfo();
            Text text1 = info_display.GetComponent<Text>();
            text1.text = pminfo;
            string pmskill = pmInfoToDisplay[buttonId + currentPage * displayList.Length].getPMskill();
            Text text2 = skill_display.GetComponent<Text>();
            text2.text = pmskill;
            string pmName = pmInfoToDisplay[buttonId + currentPage * displayList.Length].getPMname();
            Text text3 = pmNameText.GetComponent<Text>();
            text3.text = pmName;
            //loadRecordBook.displayDetails(
            //    pmInfoToDisplay[buttonId + currentPage * displayList.Length], info_display, skill_display);
        }
        else
        {
            Text text1 = info_display.GetComponent<Text>();
            text1.text = "还未发现";
            Text text2 = skill_display.GetComponent<Text>();
            text2.text = "还不知道";
            Text text3 = pmNameText.GetComponent<Text>();
            text3.text = "我是谁";
        }

        recordDetails.SetActive(true);
    }


}

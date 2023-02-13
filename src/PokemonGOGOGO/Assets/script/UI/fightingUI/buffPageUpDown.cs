using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffPageUpDown : MonoBehaviour
{
    public int[] buffIdList;

    public BUFF[] buffList;

    private int page = 1;

    private int buff1_id;
    private int buff2_id;
    private int buff3_id;
    private int buff4_id;

    // Start is called before the first frame update
    void Start()
    {
        buff1_id = buffIdList[0];
        buff2_id = buffIdList[1];
        buff3_id = buffIdList[2];
        buff4_id = buffIdList[3];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickUpPage()
    {
        if (page == 1)
        {
            Debug.Log("this is the first page");
        }
        else
        {
            page++;
            buff1_id += 4;
            buff2_id += 4;
            buff3_id += 4;
            buff4_id += 4;
            reloadBuff();
        }
    }

    public void onClickDownPage()
    {
        if (page == 3)
        {
            Debug.Log("this is the last page");
        }
        else
        {
            page--;
            buff1_id -= 4;
            buff2_id -= 4;
            buff3_id -= 4;
            buff4_id -= 4;
            reloadBuff();
        }
    }

    private static void reloadBuff()
    {
        GameObject buff1 = GameObject.Find("1_buff图标");
        GameObject buff2 = GameObject.Find("2_buff图标");
        GameObject buff3 = GameObject.Find("3_buff图标");
        GameObject buff4 = GameObject.Find("4_buff图标");
        

    }

}

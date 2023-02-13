using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite[] pms;

    void Start()
    {
        resetPM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetPM()
    {
        int cnt = 1;
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform ch = transform.GetChild(i);
            if (ch.name == "pm" + cnt)
            {
                SpriteRenderer renderer = ch.GetComponent<SpriteRenderer>();
                Vector2 size = renderer.sprite.border;
                float scale_x = 1.0f * size.x / pms[cnt].border.x;
                float scale_y = 1.0f * size.y / pms[cnt].border.y;
                renderer.sprite = pms[cnt];
                ch.localScale = new Vector3(scale_x, scale_y, 1);
                cnt++;

            }

        }

    }

}

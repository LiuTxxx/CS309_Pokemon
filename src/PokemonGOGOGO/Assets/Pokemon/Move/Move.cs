using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
//招式

public enum Attribute {Physical, Special , Status }
public class Move : MonoBehaviour
{
    public string Name;
    public Type type;//

    public Attribute attribute;//分类：物理，特殊，变化

    public int Damage;
    public int Accuracy;//先不做命中、回避和暴击
    public int PP;

}

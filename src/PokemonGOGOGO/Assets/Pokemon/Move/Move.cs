using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
//��ʽ

public enum Attribute {Physical, Special , Status }
public class Move : MonoBehaviour
{
    public string Name;
    public Type type;//

    public Attribute attribute;//���ࣺ�������⣬�仯

    public int Damage;
    public int Accuracy;//�Ȳ������С��رܺͱ���
    public int PP;

}

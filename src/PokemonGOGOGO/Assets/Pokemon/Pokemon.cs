using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type {  None, normal, fire, fighting, water, flying, grass, poison, electric, ground, psychic, rock, ice, bug, dragon, ghost, dark, steel, fairy }

public class Pokemon : MonoBehaviour
{

    public string Name;
    public int Level;
    public int maxHP, curHP;
    public int Attack, Defense, SAttack, SDefense, Speed;

    public List<Move> moveList;
    public int[] learned = {
        0,-1,-1,-1
    };
    public Type Type1;
    public Type Type2;
    
    public bool TakeDamage(int dmg)
    {
        curHP -= dmg;

        if (curHP <= 0)
        {
            curHP = 0;
            return true;
        }
        else
            return false;
    }
}


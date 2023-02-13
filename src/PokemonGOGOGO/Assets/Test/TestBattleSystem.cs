using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Battle_State { START, CHOOSE, PLAYERTURN, ENEMYTURN, WON, LOST }

public class TestBattleSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    
    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public Battle_State state;
    public Text dialogueText;
    
    private Pokemon _playerPokemon;
    private Pokemon _enemyPokemon;

    // Start is called before the first frame update
    void Start()
    {
        state = Battle_State.START;
        StartCoroutine(SetupBattle());
    }
    
    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(player, playerBattleStation);
        _playerPokemon = playerGO.GetComponent<Pokemon>();

        GameObject enemyGO = Instantiate(enemy, enemyBattleStation);
        _enemyPokemon = enemyGO.GetComponent<Pokemon>();

        dialogueText.text = "A wild " + _enemyPokemon.Name + " approaches...";

        playerHUD.SetHUD(_playerPokemon);
        enemyHUD.SetHUD(_enemyPokemon);

        yield return new WaitForSeconds(2f);

        state = Battle_State.CHOOSE;
        ChooseAction();
    }

    private void ChooseAction()
    {
        dialogueText.text = "choose an action";
    }

    public void OnMove1()
    {
        if (state != Battle_State.CHOOSE)
        {
            dialogueText.text = "test";
            return;
        }
        OrderDecision(0);
    }

    private void OrderDecision(int playerDecision)
    {
        
        if (_playerPokemon.Speed >= _enemyPokemon.Speed)//player first
        {
            state = Battle_State.PLAYERTURN;
            StartCoroutine(PlayerAction(2, playerDecision, EnemyDecision()));
        }
        else//enemy first
        {
            state = Battle_State.ENEMYTURN;
            StartCoroutine(EnemyTurn(2, playerDecision, EnemyDecision()));
        }
    }

    int EnemyDecision()
    {
        return 0;
    }

    private IEnumerator PlayerAction(int left, int playerDecision, int enemyDecision)
    {
        Move move = _playerPokemon.moveList[_playerPokemon.learned[playerDecision]];
        int damage = Damage(_playerPokemon, _enemyPokemon, move);
        bool isDead = _enemyPokemon.TakeDamage(damage);
        
        dialogueText.text = _playerPokemon.Name + " use " + move.Name + ", making " + damage + " damages.";
        enemyHUD.SetHP(_enemyPokemon.curHP);
        
        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            state = Battle_State.WON;
            EndBattle();
        }
        else if (--left > 0)
        {
            state = Battle_State.ENEMYTURN;
            StartCoroutine(EnemyTurn(left, playerDecision, enemyDecision));
        }
        else
        {
            state = Battle_State.CHOOSE;
            ChooseAction();
        }

    }

    private IEnumerator EnemyTurn(int left, int playerDecision, int enemyDecision)
    {
        Move move = _enemyPokemon.moveList[_enemyPokemon.learned[enemyDecision]];
        int damage = Damage(_enemyPokemon, _playerPokemon, move);
        bool isDead = _playerPokemon.TakeDamage(damage);
        
        dialogueText.text = _enemyPokemon.Name + " use " + move.Name + ", making " + damage + " damages.";
        playerHUD.SetHP(_playerPokemon.curHP);
        
        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            state = Battle_State.LOST;
            EndBattle();
        }
        else if (--left > 0)
        {
            state = Battle_State.PLAYERTURN;
            StartCoroutine(PlayerAction(left, playerDecision, enemyDecision));
        }
        else
        {
            state = Battle_State.CHOOSE;
            ChooseAction();
        }
    }

    private void EndBattle()
    {
        if (state == Battle_State.WON)
        {
            dialogueText.text = "YOU WIN!";
        }

        if (state == Battle_State.LOST)
        {
            dialogueText.text = "YOU LOSE!";
        }

    }

    int Damage(Pokemon attacker, Pokemon defender, Move move)//伤害计算
    {
        float basic = 1f;//基础伤害
        if (move.attribute == Attribute.Physical)
        {
            basic = (float) attacker.Attack / defender.Defense;
        }else if (move.attribute == Attribute.Special)
        {
            basic = (float) attacker.SAttack / defender.SDefense;
        }
        
        float Buff = 1f;//游戏BUFF

        float typeBuff = 1f;
        if (move.type == attacker.Type1 || move.type == attacker.Type2)
        {
            typeBuff = 1.5F;
        }

        float CriticalHit = 1f;

        float Restrain = 1f;

        return Convert.ToInt32(basic * move.Damage * Buff * typeBuff * CriticalHit * Restrain);

    }

}

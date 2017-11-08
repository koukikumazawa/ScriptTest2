using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;    // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    //  mp
    // 攻撃
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // hpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        //  mpが5以上
        if (mp >= 5)
        {
            //  mpを消費する
            mp -= 5;

            Debug.Log("魔法攻撃をした。残りＭＰは" + mp);
        }

        //  mpが足りない場合
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //--  課題-----------------------------------------------------------
        int[] array = new int[5];

        //  配列の初期化
        array[0] = 7;
        array[1] = 8;
        array[2] = 2;
        array[3] = 3;
        array[4] = 5;

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        //----------------------------------------------------------------------

        //--  発展課題----------------------------------------------------
        Boss boss = new Boss();

        //  魔法を10回使う
        for (int i = 0; i < 10; i++)
        {
            boss.Magic();
        }

        //  11回目の魔法
        boss.Magic();
        //----------------------------------------------------------------------

    }
    // Update is called once per frame
    void Update()
    {

    }
}
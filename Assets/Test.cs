using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //体力
    private int mp = 53;    //魔力
    private int power = 25; //攻撃力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic()
    {
        //MPが足りている場合
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        //MPが不足している場合
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    
}


public class Test : MonoBehaviour {
    //arrayの表示関数
    void arraymonitor(int a)
    {
        Debug.Log(a);
    }

    void Start () {
        //arrayの初期化
        int[] array = { 5, 10, 20, 40, 80 };

        //arrayの順番表示
        for (int i = 0; i < array.Length; i++)
        {
            arraymonitor(array[i]);
        }
        //arrayの逆順表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            arraymonitor(array[i]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法用の関数を呼び出す
        for(int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

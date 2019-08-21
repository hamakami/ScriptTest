using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {        
	private int hp = 100;	// 体力
	private int power = 25; // 攻撃力
	private int mp = 53;    //魔力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法攻撃用の関数
	public void mpAttack(int consumption) { 
		
		//mpの消費状態によって表示を変更
		if (this.mp >= consumption) {
			// 残りmpを消費(consumption)
			this.mp -= consumption;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else if (this.mp <= consumption) { 
			Debug.Log ("mpが足りない。");
			//処理が終了した後、残りmpは使用できなかった残りのmpの「3」であることを確認
			Debug.Log ("残りのmpは"+this.mp);
		}

	}

}



public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

		/*
		// 要素数5の配列を初期化する
		int[] array = {3, 2, 5, 1, 8};

		// 配列の要素を順番に表示する
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}



		// 配列の要素を逆順で表示する
		for (int i = array.Length-1;0<=i; i--) {
			Debug.Log (array [i]);
		}*/

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法攻撃用の関数を呼び出す(10回)
		for (int i = 0; i <= 10; i++) {
			lastboss.mpAttack (5);
		}

		// midBossクラスの変数を宣言してインスタンスを代入
		/*Boss midboss = new Boss ();

		// 攻撃用の関数を呼び出す
		midboss.Attack();
		// 防御用の関数を呼び出す
		midboss.Defence(3);*/

	}
    // Update is called once per frame
    void Update()
    {
        
    }
		
}



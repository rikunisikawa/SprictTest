using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;
	private int cost = 5;
	void Magic (){
		int restmp = mp - cost;
		if (restmp > 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + restmp);
		} else {
			Debug.Log("「MPが足りないため魔法が使えない。」");
		}
	}
	public class TestBoss : MonoBehaviour {

		// Use this for initialization
		void Start() {
//			Boss boss = new Boss ();
//			boss.Magic ();
//			for (int i = 0; i < 11; i++)
//			{
//				Debug.Log (boss);
//			}
		}

		// Update is called once per frame
		void Update(){
		}
	}
//	Bossクラスについて下記の条件を満たしてください
//	Lesson4で作成したBossクラスをもとに作成してください
//
//	int型の変数mpを宣言し、53で初期化してください
//	mpを消費して魔法攻撃をするMagic関数を作ってください
//	Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
//	Start関数で下記の条件を満たしてください
//
//	Magic関数を呼び出して、魔法を使ってください
//	Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください

}
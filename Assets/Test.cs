using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;
	public void Magic (){
		this.mp =- 3;
		if (mp > 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log("「MPが足りないため魔法が使えない。」");
		}
	}
	public class Test : MonoBehaviour {

		// Use this for initialization
		void Start() {
			Boss boss = new Boss ();
			boss.Magic ();
			for (int i = 0; i < 4; i++)
			{
				Debug.Log (boss);
			}
		}

		// Update is called once per frame
		void Update(){
		}
	}
}
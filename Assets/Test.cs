using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int [] Array = { 1,2,3,4,5};
	 for (int i = 0; i<5 ; i++)
		{
		 Debug.Log(Array[i]);
		}
		  for (int i = 4; i>=0 ; i--)
		{
		Debug.Log(Array[i]);
		}
	}
	// Update is called once per frame
	void Update () {
	}
}

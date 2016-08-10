using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    public Slider hpBar;

	void Start () {
        hpBar.value = 1;
	}
	
	void Update () {
	
	}
}

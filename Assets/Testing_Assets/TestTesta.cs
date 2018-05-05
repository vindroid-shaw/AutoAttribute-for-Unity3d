﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTesta : MonoBehaviour {

	[AutoParent] public AudioSource audioSource;
	[AutoChildren] public Collider firstCollider;
	[AutoChildren] public Collider[] allChildrenColliders_Arr;
	[AutoChildren] public List<Collider> allChildrenColliders_List;
	
	[Auto(false)] public Light myLight;
	[Auto] public TestTesta mySelf;


	void Awake () {
		firstCollider.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

﻿/// <summary>
/// 2D Space Shooter Example
/// By Bug Games www.Bug-Games.net
/// Programmer: Danar Kayfi - Twitter: @DanarKayfi
/// Special Thanks to Kenney for the CC0 Graphic Assets: www.kenney.nl
/// 
/// This is the EnemyShot Script:
/// - Enemy Ship Shot velocity
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public class EnemyShot_Script : MonoBehaviour 
{
	//Public Var
	public float speed; //EnemyRed Shot Speed

	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	void Start ()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
		_rigidbody2D.velocity = -1 * transform.up * speed; //Give Velocity to the Enemy ship shot
	}
}

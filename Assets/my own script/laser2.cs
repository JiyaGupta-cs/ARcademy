﻿using UnityEngine;
using System.Collections;

public class laser2 : MonoBehaviour
{
	public Transform startPoint;
	public Transform endPoint;
	LineRenderer laserLine;
	// Use this for initialization
	void Start()
	{
		laserLine = GetComponentInChildren<LineRenderer>();
		laserLine.SetWidth(.02f, .02f);
	}

	// Update is called once per frame
	void Update()
	{
		laserLine.SetPosition(0, startPoint.position);
		laserLine.SetPosition(1, endPoint.position);

	}
}

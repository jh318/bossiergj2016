﻿/*
Copyright (C) 2014 Nolan Baker

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions 
of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

using UnityEngine;
using System.Collections;

namespace Paraphernalia.Components {
public class PinToViewport : MonoBehaviour {

	public Camera cam;
	[Range(0,1)] public float x = 0.5f;
	public bool update = false;
	
	void Start () {
		if (cam == null) cam = Camera.main;
		if (cam == null && Camera.allCamerasCount > 0) cam = Camera.allCameras[0];
		Pin();	
	}

	[ContextMenu("Pin")]
	void Pin () {
		Vector3 p = transform.position;
		float z = cam.transform.InverseTransformPoint(p).z;
		Vector3 v = cam.ViewportToWorldPoint(new Vector3(x, 0.5f, z));
		p.x = v.x;
		transform.position = p;
	}

	void Update () {
		if (update) Pin();
	}
}
}
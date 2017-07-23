using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	TextMesh textMesh;

	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh>();
	}
	
	public void	ColorBlue(){
		textMesh.color = Color.blue;
	}

	public void	ColorGreen(){
		textMesh.color = Color.green;
	}

	public void	ColorRed(){
		textMesh.color = Color.red;
	}

	// Update is called once per frame
	void Update () {
		
	}
}

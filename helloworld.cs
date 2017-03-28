using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloworld : MonoBehaviour {

	int 	ganzzahl1 = 5;
	int 	ganzzahl2 = 10;
	float 	fliesskommazahlen = 3.14f;
	double 	flieskommazahlmalzwei = 3.14;
	bool 	trigger = false;
	char 	zeichen = 'c';
	string 	zeichenkette = "cccccccccc";
	public float  	speed = 10f;
	Vector3 position;

//	struct Vector3{
//		float x;
//		float y;
//		float z;
	// }


	void Awake(){
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 60;
//		Debug.Log ("Awake");
	}


	// Use this for initialization
	void Start () {
//		Debug.Log ("Start");
//		Debug.Log ("Hello world!");	
//		Debug.LogWarning ("Caution!");
//		Debug.LogError ("Error!");

		Debug.Log ("zahl1: " + ganzzahl1);
		Debug.Log ("zahl2: " + ganzzahl2);


		int result = Add (ganzzahl1, ganzzahl2);
		Debug.Log ("ergebnis " + result);

		Debug.Log ("zahl1: " + ganzzahl1);
		Debug.Log ("zahl2: " + ganzzahl2);

	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log ("Update");
		if (Input.GetButtonDown ("Jump")) {
		
			Debug.Log ("GetButtonDown");
		}
		if (Input.GetButton ("Jump")) {

			Debug.Log ("GetButton");
		}

		if (Input.GetButtonUp ("Jump")) {

			Debug.Log ("GetButtonUp");
		}
		if (Input.GetButton ("Horizontal")) {
			float h = Input.GetAxis ("Horizontal");
			transform.position += Vector3.right * h * Time.deltaTime * speed; // transform.position += (new Vector3(h, 0, 0)) * Time.deltaTime ;



//			Debug.Log ("h")
		}
	
	
		if (Input.GetButton ("Vertical")) {
		float h = Input.GetAxis ("Vertical");
			transform.position += Vector3.up * h * Time.deltaTime * speed; //transform.position += (new Vector3(0, h, 0)) * Time.deltaTime ;

	}
	
	}
	void LateUpdate(){
//		Debug.Log ("LateUpdate");
	}

	int Add (int a, int b){
		a = a + 1; // a++;
		b++;	   // b = b + 1;
		Debug.Log ("a: " + a);
		Debug.Log ("b: " + b);

		ganzzahl1++;
		ganzzahl2++;
	
		return a + b;
	}
		
}

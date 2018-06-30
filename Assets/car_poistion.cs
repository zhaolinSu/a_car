using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_poistion : MonoBehaviour {

	
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        print("Rotate" + this.transform.localEulerAngles);
        print("X azumith:" + this.transform.localEulerAngles.x);
        print("coordinates" + this.transform.localPosition);
        print("X axis:" + this.transform.localPosition.x);

    }
}

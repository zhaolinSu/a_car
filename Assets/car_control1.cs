using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_control1 : MonoBehaviour {
    void Awake()
    {
        for (int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
            Screen.SetResolution(Display.displays[i].renderingWidth, Display.displays[i].renderingHeight, true);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(-50 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(50 * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.W))
            this.transform.Translate(0, 0, -10 * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            this.transform.Translate(0, 0, 10 * Time.deltaTime);

        float rotationSpeed = 30.0F;
        float rotation = 1;
        if (Input.GetKey(KeyCode.G))
        {
            rotation = -1 * rotationSpeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }
        if (Input.GetKey(KeyCode.H))
        {
            rotation = 1 * rotationSpeed;
            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
        }

        print("Rotate" + this.transform.localEulerAngles);
        print("X azumith:" + this.transform.localEulerAngles.x);
        print("coordinates" + this.transform.localPosition);
        print("X axis:" + this.transform.localPosition.x);
    

}
}

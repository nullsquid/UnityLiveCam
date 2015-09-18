using UnityEngine;
using System.Collections;

public class WebcamTest : MonoBehaviour {
    WebCamTexture webcam;
	// Use this for initialization
	void Start () {
       webcam = new WebCamTexture();
       GetComponent<Renderer>().material.mainTexture = webcam;
       webcam.Play();
        //webcam.videoVerticallyMirrored
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(webcam.videoRotationAngle);
	}
}

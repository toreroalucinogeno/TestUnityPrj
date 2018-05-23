using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DajDaVidimo : MonoBehaviour {

	// Use this for initialization
	void Start () {


		
	}

	float step = 2f;
	float t = 0;
	float tt = 0;
	
	// Update is called once per frame
	void Update () {

		Debug.LogError ("Ovo se ne sme raditi u update-u");

		tt += Time.deltaTime;
		if (tt < step)
		{
			transform.Rotate (new Vector3 (10, 5, 5), Space.Self);
		}
		else if (tt > (2 * step))
		{
			tt = 0;
		}
		else
		{
			transform.Rotate (new Vector3 (5, 10, 5), Space.Self);
		}
	}
}

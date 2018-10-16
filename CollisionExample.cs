using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExample : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter()
    {
        print("OnCollisionEnter");
    }

    void OnCollisionStay()
    {
        print("OnCollisionStay");
    }

    void OnCollisionExit()
    {
        print("OnCollisionExit");
    }
}

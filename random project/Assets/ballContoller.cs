using UnityEngine;
using System.Collections;

public class ballContoller : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newposition = Vector3.zero; //= new Vector3();

        newposition.z = 0.1f;

        /*newposition.x = transform.position.x;
        newposition.y = transform.position.y+0.11f;
        newposition.z = transform.position.z;

        transform.position = newposition;*/

        Rigidbody m = GetComponent<Rigidbody>();
        m.AddForce(newposition);


        //transform.position = 

  

	}
}

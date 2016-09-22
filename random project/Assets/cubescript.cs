using UnityEngine;
using System.Collections;

public class cubescript : MonoBehaviour {


    public Object o;


	// Use this for initialization
	void Start () {
	
	}

    float lasttime;
	// Update is called once per frame
	void Update () {
	
        if(lasttime +0.1f < Time.time)
        {
            Vector3 newposition = transform.position;

            newposition.y += 10;
            newposition.x += Random.Range(-0.1f, 0.1f);
            newposition.y += Random.Range(-0.1f, 0.1f);
            newposition.z += Random.Range(-0.1f, 0.1f);

            Object temp = Instantiate(o, newposition, Quaternion.identity);

            Destroy(temp, 5);

            lasttime = Time.time;
        }


	}
}

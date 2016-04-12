using UnityEngine;
using System.Collections;

public class emiit : MonoBehaviour {
    public int speed = 30;
    public GameObject Sphere;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
            {

                Instantiate(Sphere, new Vector3(1 *Time.deltaTime * speed,0,16), Quaternion.identity);
            }

	}
}

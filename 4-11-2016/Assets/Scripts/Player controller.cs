using UnityEngine;
using System.Collections;

public class Playercontroller : MonoBehaviour {
    int jumpcount = 0;
    public float jump = 4.0f;
    private Vector3 move = Vector3.zero;
	// Use this for initialization
	void Start () {
        
	}
    void Jumpup(float y)
    {
        move.y = jump;
    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            Jumpup(gameObject.transform.position.y);
            jumpcount++;
            
            if (jumpcount == 2)
            {

            }
        }
	
	}
}

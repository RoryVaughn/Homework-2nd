using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    public int speed = 30;
    int dead = 0;
    void OnCollisionEnter(Collision col)
    {
        
        

            dead++;

        
        }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back  * speed * Time.deltaTime);

        if (dead == 5)
        {
            Application.LoadLevel(1);
        }
        
        
        
    }
}

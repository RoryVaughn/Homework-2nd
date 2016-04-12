using UnityEngine;
using System.Collections;

public class emiit : MonoBehaviour {
    public int speed = 30;
    public GameObject Sphere;
    Random rnd2 = new Random();
    public GameObject border;
    void ball()
    {

        Instantiate(Sphere, new Vector3(gameObject.transform.position.x, 0,39), Quaternion.identity);

    }
    // Use this for initialization
    void Start () {
        InvokeRepeating("ball", 1, Random.Range(1, 20));
        
    }
	
	// Update is called once per frame
	void Update () {
        


    }
}

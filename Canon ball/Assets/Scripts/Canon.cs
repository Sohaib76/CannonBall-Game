using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

    // reasearch
    //public GameObject plank1;
    //public GameObject plank2;



    public float power;

    //public CombineInstance cannonball;
    public Rigidbody2D cannonball;

    private Rigidbody2D cannonballInstance;

    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        CannonBalls();
    }

    void OnGUI() { 
      GUI.Box (new Rect(10,10,100,30), "Power: " +power);
    }

    void CannonBalls() {
        if (Input.GetKey(KeyCode.W)) {
            if (power <= 22) {
                power = power + 1;
            }
        }

        if (Input.GetKey(KeyCode.S)) {
            if (power >= 13) {
                power = power - 1;
            }
        
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnCannonBalls();
            
        }
    }

    void SpawnCannonBalls() {
        //Rigidbody2D cannonballsInstance;
        cannonballInstance = Instantiate(cannonball, new Vector3(-39.311f, -12.874f, 72), Quaternion.Euler(new Vector3(0, 0, 0)));

        cannonballInstance.transform.Rotate(0,0,54);
        cannonballInstance.velocity = new Vector2(power,power);
    }

   // researching

    //void OnCollisionEnter2D(Collision2D other){
        //if (gameObject.tag == "plank1") {
            //Time.timeScale = 0;
       // }
    //}





}

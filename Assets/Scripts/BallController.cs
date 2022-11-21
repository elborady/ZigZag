using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public static BallController instance;
	Rigidbody myRB;
	public bool isStarted;
	public float currentSpeed;
	public bool isGoingRight;
	bool isAlive = true;

	private void OnEnable()
	{
		instance = this;	
	}

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(isStarted && isAlive)
		{
			MoveBall();
			
		} 
    }

	void MoveBall()
	{
		if(isGoingRight)
		{
            Debug.Log("moving right");
            myRB.velocity = (Vector3.right * currentSpeed) + Physics.gravity;
		}
		else
		{
            Debug.Log("moving left");
            myRB.velocity = (Vector3.forward * currentSpeed) + Physics.gravity;
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "DeathZone")
		{
			isAlive = false;
			myRB.velocity = Physics.gravity;
			//MenuController.instance.Gameover();
		}
	}
}

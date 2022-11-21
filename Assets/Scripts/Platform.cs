using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	Rigidbody myRB; 

	bool hasBeenTouched;

	Transform ballTransform;
    // Start is called before the first frame update
    void Start()
    {
       myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(hasBeenTouched && myRB.isKinematic)
		{
			if(Vector3.Distance(transform.position, ballTransform.position) > 2f)
			{
				myRB.isKinematic = false;
			}
		} 
		if(transform.position.y < -10f)
		{
			Destroy(this.gameObject);
		}
    }

	private void OnCollisionEnter(Collision collision)
	
	{
		if(collision.transform.tag == "Player")
		{
			ballTransform = collision.transform;
			if(!hasBeenTouched)
			{
				PlatformGenerator.instance.NextPlatform();
				hasBeenTouched = true;
			}
		}
	}
}

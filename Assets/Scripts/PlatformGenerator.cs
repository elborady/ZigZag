using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
	[SerializeField] GameObject platformPrefab;
	[SerializeField] Transform currentPlatform;
	[SerializeField] int startingPlatformCount;

	int nextPLatformDirection;
	
	public static PlatformGenerator instance;
	
	private void OnEnable()
	{
		instance = this;
	}

    // Start is called before the first frame update
    void Start()
    {
        GenerateStartingPlatforms();

    }
	void GenerateStartingPlatforms()

	{
		for(int i = 0; i < startingPlatformCount; i++)
		{
			nextPLatformDirection = Random.Range(0, 2);
			if(nextPLatformDirection == 0)
			{
				currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.right * 2, Quaternion.identity).transform;
			}
			else
				{
				currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.forward * 2, Quaternion.identity).transform;	
				}
		}
	}
 
  public void NextPlatform()
  {
	nextPLatformDirection = Random.Range(0, 2);
			if(nextPLatformDirection == 0)
			{
				currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.right * 2, Quaternion.identity).transform;
			}
			else
			{
				currentPlatform = Instantiate(platformPrefab, currentPlatform.position + Vector3.forward * 2, Quaternion.identity).transform;	
			}
  }	
}

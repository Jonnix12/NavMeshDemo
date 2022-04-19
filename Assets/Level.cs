using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
	public int width =  20;
	public int height = 20;

	public GameObject wall;

	// Use this for initialization
	void Start()
	{
		GenerateLevel();
	}

	// Create a grid based level
	void GenerateLevel()
	{
		// Loop over the grid
		for (float x = transform.position.x; x <= transform.position.x + width; x += 2)
		{
			for (float y = transform.position.z; y <= transform.position.z + height; y += 2)
			{
				// Should we place a wall?
				if (Random.value > .7f)
				{
					// Spawn a wall
					Vector3 pos = new Vector3(x - width / 2f, 1.5f, y - height / 2f);
					Instantiate(wall, pos, Quaternion.identity, transform);
				}
			}
		}
	}
}

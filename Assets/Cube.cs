using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	public float moveSpeed = 1f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime,
		                    0f,
		                    moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}

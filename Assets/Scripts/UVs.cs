using UnityEngine;
using System.Collections;

public class UVs : MonoBehaviour
{
	// Determines the 'speed' of the texture UVs over time
	public Vector2 UVOffsetSpeed;

	public bool _IsScrolling;

	void Update ()
	{
		if(_IsScrolling)
		{
			// Pass UV speeds to material
			GetComponent<Renderer>().material.SetTextureOffset("_MainTex", UVOffsetSpeed * Time.time);
		}
	}

	public void SetIsScrolling()
	{
		_IsScrolling = !_IsScrolling;
	}
}
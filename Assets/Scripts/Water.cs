using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour
{
	// Determines the 'speed' of the texture UVs over time
	public Vector2 UV1OffsetSpeed;
	public Vector2 UV2OffsetSpeed;

	bool _IsScrolling;

	void Update ()
	{
		if(_IsScrolling)
		{
			// Pass UV speeds to material
			GetComponent<Renderer>().material.SetTextureOffset("_WaterTex1", UV1OffsetSpeed * Time.time);
			GetComponent<Renderer>().material.SetTextureOffset("_WaterTex2", UV2OffsetSpeed * Time.time);
		}
	}

	public void SetIsScrolling()
	{
		_IsScrolling = !_IsScrolling;
	}
}

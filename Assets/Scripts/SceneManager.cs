using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour
{
	// Steps
	public GameObject _Step1;
	public GameObject _Step2;
	public GameObject _Step3;
	public GameObject _Step4;
	public GameObject _Step5;

	// UV imgaes in step 2
	public GameObject _UV1;
	public GameObject _UV2;

	// Water images in step 3
	public GameObject _WaterPlane1;
	public GameObject _WaterPlane2;
	public GameObject _WaterPlane3;
	public GameObject _WaterPlane4;

	// Buttons in steps 2 and 3 (for toggling UV movement)
	public GameObject _UVButtonStep2;
	public GameObject _UVButtonStep3;

	// Text GameObjects
	public GameObject _Step1Text;
	public GameObject _Step2Text;
	public GameObject _Step3Text;
	public GameObject _Step4Text;
	public GameObject _Step5Text;

	#region Button Functions
	public void StartUVs()
	{
		_UV1.GetComponent<UVs>().SetIsScrolling();
		_UV2.GetComponent<UVs>().SetIsScrolling();
	}

	public void StartUVs2()
	{
		_WaterPlane1.GetComponent<Water>().SetIsScrolling();
		_WaterPlane2.GetComponent<Water>().SetIsScrolling();
		_WaterPlane3.GetComponent<Water>().SetIsScrolling();
		_WaterPlane4.GetComponent<Water>().SetIsScrolling();
	}

	public void Step1()
	{
		_Step1.SetActive(true);
		_Step2.SetActive(false);
		_Step3.SetActive(false);
		_Step4.SetActive(false);
		_Step5.SetActive(false);

		_UVButtonStep2.SetActive(false);
		_UVButtonStep3.SetActive(false);
	}

	public void Step2()
	{
		_Step1.SetActive(false);
		_Step2.SetActive(true);
		_Step3.SetActive(false);
		_Step4.SetActive(false);
		_Step5.SetActive(false);

		_UVButtonStep2.SetActive(true);
		_UVButtonStep3.SetActive(false);
	}

	public void Step3()
	{
		_Step1.SetActive(false);
		_Step2.SetActive(false);
		_Step3.SetActive(true);
		_Step4.SetActive(false);
		_Step5.SetActive(false);

		_UVButtonStep2.SetActive(false);
		_UVButtonStep3.SetActive(true);
	}

	public void Step4()
	{
		_Step1.SetActive(false);
		_Step2.SetActive(false);
		_Step3.SetActive(false);
		_Step4.SetActive(true);
		_Step5.SetActive(false);

		_UVButtonStep2.SetActive(false);
		_UVButtonStep3.SetActive(false);
	}

	public void Step5()
	{
		_Step1.SetActive(false);
		_Step2.SetActive(false);
		_Step3.SetActive(false);
		_Step4.SetActive(false);
		_Step5.SetActive(true);

		_UVButtonStep2.SetActive(false);
		_UVButtonStep3.SetActive(false);
	}

	public void ToggleText()
	{
		_Step1Text.SetActive(!_Step1Text.activeInHierarchy);
		_Step2Text.SetActive(!_Step2Text.activeInHierarchy);
		_Step3Text.SetActive(!_Step3Text.activeInHierarchy);
		_Step4Text.SetActive(!_Step4Text.activeInHierarchy);
		_Step5Text.SetActive(!_Step5Text.activeInHierarchy);
	}

	public void LinkToVideo()
	{
		Application.OpenURL("https://www.youtube.com/watch?v=Ipsd6rYj6Mk");
	}
	#endregion
}

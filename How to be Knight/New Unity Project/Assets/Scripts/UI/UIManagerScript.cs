using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

	public Slider Volume;

    public void DisableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", false);
    }

    public void EnableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
	
	/*public void SetFullScreen(bool isFullscreen)
	{
		if(isFullscreen)
		{
			Resolution[] allResolutions = Screen.resolution;
			Resolution maxResolution = allResolutions[allResolutions.Length - 1];
			Screen.SetResolution(maxResolution.width, maxResolution.height, true);
		}	
		else
		{
			SetScreenResolution();
		}	
	}*/
	
	public void Update()
	{
        GetComponent<AudioSource>().volume = Volume.value;
	}
}

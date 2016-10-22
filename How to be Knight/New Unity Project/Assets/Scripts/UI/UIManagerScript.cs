using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

    public Animator animator1;
    public Animator animator2;
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
}

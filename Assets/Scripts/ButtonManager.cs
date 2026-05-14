using UnityEngine;
using System.Collections;
public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Animator[] songButtons;
    [SerializeField]
    private Animator closeButton;
    [SerializeField]
    private float timeBetweenBottons = 0.1f;
    [SerializeField]
    private string showAnimationName = "Show";
    [SerializeField]
    private string hideAnimationName = "Hide";
    public void ShowSongButton()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(showAnimationName));
    }
    public void HideSongButtons()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(hideAnimationName));
    }
    private IEnumerator AnimateButtons(string animationName)
    {
        foreach ( Animator button in songButtons)
        {
            closeButton.Play(animationName);
            yield return new WaitForSeconds(timeBetweenBottons);
        }
    }
    public void ShowCloseButton()
    {
        closeButton.Play(showAnimationName);
    }
    public void HideCloseButton()
    {
        closeButton.Play(hideAnimationName);
    }
}

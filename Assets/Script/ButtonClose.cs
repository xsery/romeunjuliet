using UnityEngine;

public class ButtonClose : MonoBehaviour {

    public GameObject credits;
    public GameObject play;
    public AudioSource button;

    public void OnMouseDown()
    {
        button.Play();
        credits.SetActive(false);
        play.SetActive(true);
    }
}

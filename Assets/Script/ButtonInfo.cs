using UnityEngine;

public class ButtonInfo : MonoBehaviour {

    public AudioSource button;
    public GameObject credits;
    public GameObject play;

    void Start()
    {
        credits.SetActive(false);
        play.SetActive(true);
    }

    public void OnMouseDown()
    {
        button.Play();
        credits.SetActive(true);
        play.SetActive(false);
    }
}


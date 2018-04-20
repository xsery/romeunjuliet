using UnityEngine;

public class ButtonPlayPause : MonoBehaviour {

    public AudioSource button;
    public GameObject popup;

    public void OnMouseDown()
    {
        button.Play();
        Time.timeScale = 1;
        popup.SetActive(false);
    }
}

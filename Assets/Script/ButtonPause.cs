using UnityEngine;

public class ButtonPause : MonoBehaviour {

    public AudioSource button;
    public GameObject popup;

    // Use this for initialization
    void Start()
    {
        popup.SetActive(false);
    }

    public void OnMouseDown()
    {
        popup.SetActive(true);
        button.Play();
        Time.timeScale = 0;
    }
}

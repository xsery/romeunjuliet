using UnityEngine;

public class ButtonSound : MonoBehaviour {

    public AudioSource button;
    private Animator an;

    void Start()
    {
        an = GetComponent<Animator>();
    }

    void Update()
    {
        if(AudioListener.pause == true)
        {
            an.SetBool("Mute", true);
        } else
        {
            an.SetBool("Mute", false);
        }

    }


    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
        button.Play();
    }
}

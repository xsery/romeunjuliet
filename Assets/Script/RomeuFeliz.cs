using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RomeuFeliz : MonoBehaviour {

    public AudioSource vitoria;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            StartCoroutine("happy");

        }
    }

    IEnumerator happy()
    {
        vitoria.Play();
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(2);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Scenes/Final");
    }
}

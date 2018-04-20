using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Carta : MonoBehaviour {

    public AudioSource som;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            som.Play();
            StartCoroutine("count");
            
        }
    }

    IEnumerator count()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(2);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Scenes/TransicaoDeFase");
    }

}

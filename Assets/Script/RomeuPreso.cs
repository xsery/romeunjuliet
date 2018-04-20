using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RomeuPreso : MonoBehaviour {

    public AudioSource sos;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            StartCoroutine("subiu");

        }
    }

    IEnumerator subiu()
    {
        sos.Play();
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        sos.Play();
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        transform.position = new Vector2(transform.position.x, transform.position.y + 10);
        yield return new WaitForSeconds(0.4f);
        sos.Play();
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(2);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Scenes/Fase3");
    }
}

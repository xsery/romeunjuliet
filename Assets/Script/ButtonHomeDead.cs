using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHomeDead : MonoBehaviour {

    public AudioSource button;

    public void OnMouseDown()
    {
        button.Play();
        StartCoroutine("count");
    }

    IEnumerator count()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(2);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Scenes/Menu");
    }
}

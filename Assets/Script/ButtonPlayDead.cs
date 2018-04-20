using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlayDead : MonoBehaviour {

    public AudioSource button;
    public Player player;

    public void OnMouseDown()
    {
        button.Play();
        StartCoroutine("count");
    }

    IEnumerator count()
    {
        GameManager.Instance.zerarColetor();
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(2);
        yield return new WaitForSeconds(1.5f);
        if (player.level == 1)
            SceneManager.LoadScene("Scenes/Fase1");
        if (player.level == 2)
            SceneManager.LoadScene("Scenes/Fase2");
        if (player.level == 3)
            SceneManager.LoadScene("Scenes/Fase3");
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoDeFase : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("count");
    }

    IEnumerator count()
    {
        yield return new WaitForSeconds(13f);
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(2);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Scenes/Fase2");
    }
}

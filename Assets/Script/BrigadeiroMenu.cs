using UnityEngine;

public class BrigadeiroMenu : MonoBehaviour {

    public GameObject brigadeiroAzul;
    public GameObject brigadeiroAmarelo;
    public GameObject brigadeiroRoxo;
    public GameObject brigadeiroRosa;

	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.brigadeiroAzul)
            brigadeiroAzul.SetActive(true);
        else
            brigadeiroAzul.SetActive(false);
        if (GameManager.Instance.brigadeiroAmarelo)
            brigadeiroAmarelo.SetActive(true);
        else
            brigadeiroAmarelo.SetActive(false);
        if (GameManager.Instance.brigadeiroRoxo)
            brigadeiroRoxo.SetActive(true);
        else
            brigadeiroRoxo.SetActive(false);
        if (GameManager.Instance.brigadeiroRosa)
            brigadeiroRosa.SetActive(true);
        else
            brigadeiroRosa.SetActive(false);
    }
}

using UnityEngine;

public class PlayerBrigadeiro : MonoBehaviour {

    public AudioSource sons;
    public string doce;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            sons.Play();
            if(doce == "Amarelo")
                GameManager.Instance.brigadeiroAmarelo = true;
            if (doce == "Azul")
                GameManager.Instance.brigadeiroAzul = true;
            if (doce == "Roxo")
                GameManager.Instance.brigadeiroRoxo = true;
            if (doce == "Rosa")
                GameManager.Instance.brigadeiroRosa = true;
            if (GameManager.Instance.brigadeiroRosa && GameManager.Instance.brigadeiroAzul
                && GameManager.Instance.brigadeiroAmarelo && GameManager.Instance.brigadeiroRoxo)
                GameManager.Instance.TodosBrigadeiros();
            Destroy(gameObject);
        }
    }

}

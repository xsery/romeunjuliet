using UnityEngine;

public class Bolo : MonoBehaviour {
    

    public AudioSource sons;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            sons.Play();
            GameManager.Instance.CollectBolo();
            Destroy(gameObject);
        }
    }
}

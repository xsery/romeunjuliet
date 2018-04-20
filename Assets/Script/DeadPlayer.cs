using UnityEngine;

public class DeadPlayer : MonoBehaviour
{

    public GameObject popUpMorte;
    public AudioSource morte;
    public Player Player;
    private bool dead;

    // Use this for initialization
    void Start()
    {
        popUpMorte.SetActive(false);
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Life == 0)
        {
            popUpMorte.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Dead")
        {
            if (!dead)
            {
                dead = true;
                morte.Play();
                GameManager.Instance.PerdeVida();
                Player.estaVivo = false;
            }
        }
    }
}

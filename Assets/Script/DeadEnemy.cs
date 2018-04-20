using System.Collections;
using UnityEngine;

public class DeadEnemy : MonoBehaviour {
    private Animator an;

    public Transform verificaEnemy;

    public Rigidbody2D Player;

    private bool derrota;

    public float raioValidaEnemy;

    public LayerMask morteEnemy;

    public AudioSource som;

    // Use this for initialization
    void Start () {
        an = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        derrota = Physics2D.OverlapCircle(verificaEnemy.position, raioValidaEnemy, morteEnemy);

        if (derrota)
        {
            
            StartCoroutine("dead");
            
        }
    }

    IEnumerator dead()
    {
        som.Play();
        Player.AddForce(Player.transform.up * 10000);
        an.SetBool("Dead", (true));
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(verificaEnemy.position, raioValidaEnemy);
    }
}

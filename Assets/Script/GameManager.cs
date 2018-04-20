using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public int Life;

    public bool Life1;
    public bool Life2;
    public bool Life3;
    public bool Life4;
    public bool Life5;
    public bool Life6;
    public bool Life7;
    public bool Life8;
    public bool Life9;
    public bool Life10;

    public bool brigadeiroAzul;
    public bool brigadeiroAmarelo;
    public bool brigadeiroRoxo;
    public bool brigadeiroRosa;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameManager";
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);
                }
            }
            return instance;
        }
    }



    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void zerarColetor()
    {
        brigadeiroAmarelo = false;
        brigadeiroAzul = false;
        brigadeiroRoxo = false;
        brigadeiroRosa = false;
        Life = 3;
    }

    public void CollectBolo()
    {
        if(Life < 10)
        {
            Life += 1;
        }
    }

    public void PerdeVida()
    {
        Life -= 1;
    }

    void Start()
    {

    }


    void Update()
    {
        if (Life == 0){
            Life1 = false;
            Life2 = false;
            Life3 = false;
            Life4 = false;
            Life5 = false;
            Life6 = false;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 1){
            Life1 = true;
            Life2 = false;
            Life3 = false;
            Life4 = false;
            Life5 = false;
            Life6 = false;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 2)
        {
            Life1 = true;
            Life2 = true;
            Life3 = false;
            Life4 = false;
            Life5 = false;
            Life6 = false;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 3)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = false;
            Life5 = false;
            Life6 = false;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 4)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = false;
            Life6 = false;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 5)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = true;
            Life6 = false;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 6)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = true;
            Life6 = true;
            Life7 = false;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 7)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = true;
            Life6 = true;
            Life7 = true;
            Life8 = false;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 8)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = true;
            Life6 = true;
            Life7 = true;
            Life8 = true;
            Life9 = false;
            Life10 = false;
        }
        if (Life == 9)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = true;
            Life6 = true;
            Life7 = true;
            Life8 = true;
            Life9 = true;
            Life10 = false;
        }
        if (Life == 10)
        {
            Life1 = true;
            Life2 = true;
            Life3 = true;
            Life4 = true;
            Life5 = true;
            Life6 = true;
            Life7 = true;
            Life8 = true;
            Life9 = true;
            Life10 = true;
        }
    }

    public bool control;

    public void TodosBrigadeiros()
        {
            brigadeiroAmarelo = false;
            brigadeiroAzul = false;
            brigadeiroRosa = false;
            brigadeiroRoxo = false;
            if (Life< 10)
                    Life += 1;
        }
}

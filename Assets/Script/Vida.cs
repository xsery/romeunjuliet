using UnityEngine;

public class Vida : MonoBehaviour {

    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject vida4;
    public GameObject vida5;
    public GameObject vida6;
    public GameObject vida7;
    public GameObject vida8;
    public GameObject vida9;
    public GameObject vida10;
    
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Life1)
            vida1.SetActive(true);
        else
            vida1.SetActive(false);
        if (GameManager.Instance.Life2)
            vida2.SetActive(true);
        else
            vida2.SetActive(false);
        if (GameManager.Instance.Life3)
            vida3.SetActive(true);
        else
            vida3.SetActive(false);
        if (GameManager.Instance.Life4)
            vida4.SetActive(true);
        else
            vida4.SetActive(false);
        if (GameManager.Instance.Life5)
            vida5.SetActive(true);
        else
            vida5.SetActive(false);
        if (GameManager.Instance.Life6)
            vida6.SetActive(true);
        else
            vida6.SetActive(false);
        if (GameManager.Instance.Life7)
            vida7.SetActive(true);
        else
            vida7.SetActive(false);
        if (GameManager.Instance.Life8)
            vida8.SetActive(true);
        else
            vida8.SetActive(false);
        if (GameManager.Instance.Life9)
            vida9.SetActive(true);
        else
            vida9.SetActive(false);
        if (GameManager.Instance.Life10)
            vida10.SetActive(true);
        else
            vida10.SetActive(false);
    }   
}

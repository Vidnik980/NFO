using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private GameObject player;
    public GameObject target;
    private int dist;
    private int distattak;
    private float timer = 1;
    private int hp = 2;
    public GameObject coint1, coint2, coint3;
    public GameObject NFO;
    public GameObject place;
    void Start()
    {
        target = GameObject.Find("NFOtarget");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((target.transform.position - transform.position).normalized  / 50);
    }
        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Destroy(other.gameObject);
            hp--;
            if (hp <= 0)
            {
                Coint();
                if (NFO != null)
                {
                    Destroy(NFO);
                }
                else
                Destroy(gameObject);
            }
        }
    }
    public void Coint()
    {
        int a = Random.Range(1, 4);
        switch (a)
        {
            case 1:
                GameObject coint11 = Instantiate(coint1,gameObject.transform);
                coint11.transform.SetParent(null);
                coint11.transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
                break;

            case 2:
                GameObject coint12 = Instantiate(coint2, gameObject.transform);
                coint12.transform.SetParent(null);
                coint12.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                break;

            case 3:
                GameObject coint13 = Instantiate(coint3, gameObject.transform);
                coint13.transform.SetParent(null);
                coint13.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                break;
        }
    }
}
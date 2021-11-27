using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public GameObject colorbullet;
    public Text HPtext;
    public Text Cointtext;
    public int hp;
    public int coint;
    private float timer;
    private bool chechAttak;
    void Start()
    {
        colorbullet = GameObject.Find("ShotButton");
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            chechAttak = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coint1")
        {
            colorbullet.GetComponent<ShootScript>().colorbullet = 1;
            colorbullet.GetComponent<ShootScript>().color();
            coint++;
            Cointtext.text = "Coint: " + coint.ToString();
            Destroy(other.transform.parent.gameObject);
        }
        if (other.gameObject.tag == "coint2")
        {
            colorbullet.GetComponent<ShootScript>().colorbullet = 2;
            colorbullet.GetComponent<ShootScript>().color();
            coint++;
            Cointtext.text = "Coint: " + coint.ToString();
            Destroy(other.transform.parent.gameObject);
        }
        if (other.gameObject.tag == "coint3")
        {
            colorbullet.GetComponent<ShootScript>().colorbullet = 3;
            colorbullet.GetComponent<ShootScript>().color();
            coint++;
            Cointtext.text = "Coint: " + coint.ToString();
            Destroy(other.transform.parent.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "attak")
        {
            if (chechAttak == true)
            {
                DamageToPlayer(5);
                timer = 1;
                chechAttak = false;
            }
        }
    }
    public void DamageToPlayer(int force)
    {
        hp-= force;
        HPtext.text = hp.ToString();
        if (hp <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}

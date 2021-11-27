using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject bullet, bullet1, bullet2, bullet3, gun;
    private bool shotcheck;
    private float gap = 0.3f;
    private float timer;
    public int colorbullet;
    void Update()
    {
        if (shotcheck == true)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                shot();
                timer = gap;
            }
        }
    }
    public void shot()
    {
        gameObject.GetComponent<AudioSource>().Play();
        GameObject CloneBullet = Instantiate(bullet, gun.transform.position, gun.transform.rotation);
        CloneBullet.GetComponent<Rigidbody>().AddForce(gun.transform.forward * 1000);
        Destroy(CloneBullet, 5);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        shotcheck = true;
        timer = gap;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        shotcheck = false;
    }
    public void color()
    {
        switch (colorbullet)
        {
            case 1:
                bullet = bullet1;
                break;
            case 2:
                bullet = bullet2;
                break;
            case 3:
                bullet = bullet3;
                break;
        }
    }
}

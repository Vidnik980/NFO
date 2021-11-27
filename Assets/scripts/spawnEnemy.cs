using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    private float timer;
    public GameObject enemy;
    public Transform player;
    private float x1;
    private float z1;

    private int rotation;
    private int distance;

    void Update()
    {

        timer -= Time.deltaTime;
        if (timer < 0)
        {

            logics();
        }
    }

    public void logics()
    {
        rotation = Random.Range(90, 270);
        distance = Random.Range(10, 100);
        rotation = (int)(player.localEulerAngles.y) - rotation;
        x1 = (player.transform.position.x) + Mathf.Sin(rotation * Mathf.Deg2Rad) * distance;
        z1 = (player.transform.position.z) + Mathf.Cos(rotation * Mathf.Deg2Rad) * distance;


        GameObject enemyClon = Instantiate(enemy, gameObject.transform);
        enemyClon.transform.localScale = new Vector3(0.09f, 1f, 0.09f);
        enemyClon.transform.position = new Vector3(x1, Random.Range(3, 6), z1);
        timer = 3;

    }
}

using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using NUnit.Framework;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Define 
    [SerializeField] GameObject meteor;
    [SerializeField] GameObject win_zone;
    [SerializeField] int enemy_speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        EnemyMove();
    }

    public void EnemyMove()
    {
        transform.Translate(Vector2.down * Time.deltaTime * enemy_speed);
    }

    public void EnemyDead()
    {
        //Score

        FindFirstObjectByType<GameManager>().AddScore();

        //Kill Enemy
        Destroy(gameObject);

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Projectile laser = collision.GetComponent<Projectile>();

        if (laser != null)
        {
            EnemyDead();
        }

        OuttaBounds win_zone = collision.GetComponent<OuttaBounds>();

        if (win_zone != null)
        {
            SceneManager.LoadScene("Game_Over");
        }
    }
}

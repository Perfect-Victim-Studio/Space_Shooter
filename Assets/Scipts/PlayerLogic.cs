using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using NUnit.Framework;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{
    // Define

    [SerializeField] int player_speed = 1;
    [SerializeField] GameObject laser;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
        Shoot();
    }

    public void Move()
    {
        player_speed = 12;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * player_speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * player_speed);
        }
        else
        {
            player_speed = 0;
        }
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }
}

using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject laser;
    [SerializeField] int laser_speed = 20;


    void Start()
    {

    }

    void Update()
    {
        ShootMove();
        Die();
    }

    public void ShootMove()
    {
        transform.Translate(Vector2.up * Time.deltaTime * laser_speed);
    }

    public void Die()
    {
        if (transform.position.y > 3)
        {
            Destroy(gameObject);
        }
    }

}


using UnityEngine;

public class Enemy : MonoBehaviour
{
    public  Player player;

    public string name;
    public int maxHealth;
    public int currentHealth;
    public int damage;
    public string enemy;

    public float movementSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }
    
    public virtual void Attack() {}
    public virtual void Move(){}

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
            Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}

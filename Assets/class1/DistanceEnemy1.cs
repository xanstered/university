
using UnityEngine;

public class DistanceEnemy1 : Enemy
{
    public float minimumDistanceToTarget = 10f;
    public override void Attack()
    {
        base.Attack();
        if (Vector3.Distance(transform.position, player.transform.position) < minimumDistanceToTarget)
        {
            player.TakeDamage(damage);
        }
    }

    public override void Move()
    {
        base.Move();
        if (Vector3.Distance(transform.position, player.transform.position) > minimumDistanceToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
        }
    }

}
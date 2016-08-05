using UnityEngine;
using System.Collections;

public class EnemyHandler : MonoBehaviour {
    PlayerController player;

    public Transform target;
    private Vector3 target_pos;
    private Vector3 object_pos;

    private float angle;
    private float health;
    private float armor;
    private float melee;
    private float ranged;

    private int mechSize; //0 Small, 1 Medium, 2 Large

    private float movementSpeed;
    private float attackSpeed;
    private float regenspeed;
    private float cooldown;

    public GameObject Bullet;

    // Use this for initialization
    void Start () {
        player = new PlayerController();

        movementSpeed = 10f;
        attackSpeed = 0.5f;
        health = 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet(Player)")
        {
            Damage(player.damage);

            Destroy(col.gameObject);

            Debug.Log("yes");
        }
    }
	
	// Update is called once per frame
	void Update () {

        //Alive check
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        //Rotate to player
        Vector3 vectorToTarget = target.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 10);
    }

    void Damage(float i)
    {
        health -= (int)i;
    }
}

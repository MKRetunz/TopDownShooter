using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    PlayerStats statRef;

    private int health;
    private int armor;
    private int melee;
    private int ranged;

    private int mechSize; //0 Small, 1 Medium, 2 Large

    private float movementSpeed;
    private float attackSpeed;
    private float regenspeed;
    private float cooldown;

    private Transform Head;

    public GameObject Bullet;

	// Use this for initialization
	void Start () {
        statRef = new PlayerStats();

        movementSpeed = 10f;
        attackSpeed = 0.5f;

        Head = transform.FindChild("Head");

        //getStats();
    }
	
	// Update is called once per frame
	void Update () {

        //Setting stats

        getStats();
        
        //Controlls

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
        if (cooldown >= attackSpeed && Input.GetMouseButton(0))
        {
            FireBullet();
        }
        cooldown += Time.deltaTime;
    }

    void getStats ()
    {
        health = statRef.GetHealth(mechSize);

        Debug.Log(health);
    }

    void FireBullet ()
    {
        GameObject Clone = (Instantiate(Bullet, transform.position, Head.transform.rotation)) as GameObject;
    }
}

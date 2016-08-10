using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    PlayerStats statRef;

    private float health;
    private float armor;
    private float melee;
    private float ranged;

    private int mechSize; //0 Small, 1 Medium, 2 Large

    public float damage = 1;
    private float movementSpeed;
    private float attackSpeed;
    private float regenspeed;
    private float cooldown;

    private Transform Head;

    public GameObject Bullet;

	// Use this for initialization
	void Start () {
        statRef = new PlayerStats();

        mechSize = 1;

        movementSpeed = 10f;
        attackSpeed = 0.5f;

        Head = transform.FindChild("Head");

        //Setting stats
        getStats();
    }
	
	// Update is called once per frame
	void Update () {

        //Alive check
        if(health <= 0)
        {
            Destroy(gameObject);
        }


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
        armor = statRef.GetArmor();
        melee = statRef.GetMelee();
        ranged = statRef.GetRange();
        movementSpeed = statRef.GetSpeed();
        regenspeed = statRef.GetRegen();

        float charAg = statRef.GetAgility();
        movementSpeed *= charAg;

        float chardef = statRef.GetDefense();
        armor *= chardef;

        float charStr = statRef.GetStrength();
        melee *= charStr;

        float charDex = statRef.GetDexterity();
        ranged *= charDex;

        float charRep = statRef.GetRepair();
        regenspeed *= charRep;
    }

    void FireBullet ()
    {
        GameObject Clone = (Instantiate(Bullet, transform.position, Head.transform.rotation)) as GameObject;
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    PlayerStats statRef;
    SceneControl sceneControl;

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
        sceneControl = new SceneControl();

        gameObject.tag = "Player";

        Head = transform.FindChild("Head");

        //Setting stats: Default
        getStats(1, 1);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BulletEnemy")
        {
            TakeDamage();

            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

        //Testing 
        if (Input.GetKey(KeyCode.Alpha1))
        {
            getStats(1, 1);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            getStats(2, 2);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            getStats(3, 3);
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
            cooldown = 0f;
        }
        cooldown += Time.deltaTime;
    }

    void getStats (int mechChoice, int charChoice)
    {
        if (mechChoice == 1)
        {
            mechSize = 2;
        }
        if (mechChoice == 2)
        {
            mechSize = 1;
        }
        if (mechChoice == 3)
        {
            mechSize = 0;
        }

        health = statRef.GetHealth(mechSize);
        armor = statRef.GetArmor(mechChoice);
        melee = statRef.GetMelee(mechChoice);
        ranged = statRef.GetRange(mechChoice);
        movementSpeed = statRef.GetSpeed(mechChoice);
        regenspeed = statRef.GetRegen(mechChoice);
        attackSpeed = statRef.GetFireRate(mechChoice);

        float charAg = statRef.GetAgility(charChoice);
        movementSpeed *= charAg;

        float chardef = statRef.GetDefense(charChoice);
        armor *= chardef;

        float charStr = statRef.GetStrength(charChoice);
        melee *= charStr;

        float charDex = statRef.GetDexterity(charChoice);
        ranged *= charDex;

        float charRep = statRef.GetRepair(charChoice);
        regenspeed *= charRep;


        //Placeholder
        damage = ranged * 100;
    }

    void FireBullet ()
    {
        GameObject Clone = (Instantiate(Bullet, transform.position, Head.transform.rotation)) as GameObject;
    }

    void TakeDamage()
    {
        health -= 500;

        //Alive check
        if (health <= 0)
        {
            sceneControl.PlayerDefeat();
        }
    }
}

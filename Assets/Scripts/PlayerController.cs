using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private float MovementSpeed;
    private float Attackspeed;
    private float Cooldown;
    private Transform Head;

    public GameObject Bullet;

	// Use this for initialization
	void Start () {

        MovementSpeed = 10;
        Attackspeed = 0.5f;

        Head = transform.FindChild("Head");
	}
	
	// Update is called once per frame
	void Update () { 
        //Controlls

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, MovementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -MovementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-MovementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(MovementSpeed * Time.deltaTime, 0, 0);
        }
        if (Cooldown >= Attackspeed && Input.GetMouseButton(0))
        {
            FireBullet();
        }
        Cooldown += Time.deltaTime;
    }

    void FireBullet ()
    {
        GameObject Clone = (Instantiate(Bullet, transform.position, Head.transform.rotation)) as GameObject;
    }
}

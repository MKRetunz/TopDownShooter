using UnityEngine;
using System.Collections;

public class BulletAlly : MonoBehaviour {
    private float Speed;
    private float SelfDeleteTimer;

	// Use this for initialization
	void Start () {
        Speed = 20;
        SelfDeleteTimer = 0.0f;

        gameObject.tag = "Bullet(Player)";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       transform.Translate(Speed * Time.deltaTime, 0, 0);
    }

    void Update ()
    {
        SelfDeleteTimer += Time.deltaTime;
        if(SelfDeleteTimer >= 0.3f)
        {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
    //Machine stats
    private int healthMech;
    private int sizeMech;
    private int speedMech;
    private int armorMech;
    private int meleeMech;
    private int rangeMech;

    private float regenMech;
    private float fireRateMech;

    //Character stats
    private int agilityChar;
    private int defenseChar;
    private int strengthChar;
    private int dexterityChar;

    private int repairChar;

    // Use this for initialization
    void Start () {
        healthMech = 0;
        sizeMech = 0;
        speedMech = 0;
        armorMech = 0;
        meleeMech = 0;
        rangeMech = 0;
        regenMech = 0;
        fireRateMech = 0;

        agilityChar = 0;
        defenseChar = 0;
        strengthChar = 0;
        dexterityChar = 0;
        repairChar = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

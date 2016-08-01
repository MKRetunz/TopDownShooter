using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
    //Machine stats
    private int healthMech;
    private int speedMech;
    private int armorMech;
    private int meleeMech;
    private int rangeMech;

    private float regenMech;
    private float fireRateMech;

    //Character stats
    private float agilityChar;
    private float defenseChar;
    private float strengthChar;
    private float dexterityChar;

    private float repairChar;

    // Use this for initialization
    void Start () {
        healthMech = 0;
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

    public int GetHealth(int size)
    {
        if (size == 0)
        {
            healthMech = 10000;
        }
        if (size == 1)
        {
            healthMech = 15000;
        }
        if (size == 2)
        {
            healthMech = 20000;
        }
        else {
            Debug.Log("Invalid");
        }
        return healthMech;
    }

    public int GetSpeed()
    {
        speedMech = 10;

        return speedMech;
    }

    public int GetArmor()
    {
        armorMech = 1000;

        return armorMech;
    }

    public int GetMelee()
    {
        meleeMech = 100;

        return meleeMech;
    }

    public int GetRange()
    {
        rangeMech = 100;

        return rangeMech;
    }

    public float GetRegen()
    {
        regenMech = 10f;

        return regenMech;
    }

    public float GetFireRate()
    {
        fireRateMech = 1f;

        return fireRateMech;
    }

    public float GetAgility()
    {
        agilityChar = 1f;

        return agilityChar;
    }

    public float GetDefense()
    {
        defenseChar = 1f;

        return defenseChar;
    }

    public float GetStrength()
    {
        strengthChar = 1f;

        return strengthChar;
    }

    public float GetDexterity()
    {
        dexterityChar = 1f;

        return dexterityChar;
    }

    public float GetRepair()
    {
        repairChar = 1f;

        return repairChar;
    }
}

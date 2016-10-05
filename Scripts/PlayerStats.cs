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
        else if (size == 1)
        {
            healthMech = 15000;
        }
        else if (size == 2)
        {
            healthMech = 20000;
        }
        else {
            Debug.Log("Invalid");
        }
        return healthMech;
    }

    public int GetSpeed(int mechNum)
    {
        if (mechNum == 1)
        {
            speedMech = 10;
        }
        else if (mechNum == 2)
        {
            speedMech = 20;
        }
        else if (mechNum == 3)
        {
            speedMech = 30;
        }
        else
        {
            speedMech = 0;

            Debug.Log("Error handler");
        }

        return speedMech;
    }

    public int GetArmor(int mechNum)
    {
        if (mechNum == 1)
        {
            armorMech = 1000;
        }
        else if (mechNum == 2)
        {
            armorMech = 750;
        }
        else if (mechNum == 3)
        {
            armorMech = 500;
        }
        else
        {
            armorMech = 0;

            Debug.Log("Error handler");
        }

        return armorMech;
    }

    public int GetMelee(int mechNum)
    {
        if (mechNum == 1)
        {
            meleeMech = 100;
        }
        else if (mechNum == 2)
        {
            meleeMech = 150;
        }
        else if (mechNum == 3)
        {
            meleeMech = 200;
        }
        else
        {
            meleeMech = 0;

            Debug.Log("Error handler");
        }

        return meleeMech;
    }

    public int GetRange(int mechNum)
    {
        if (mechNum == 1)
        {
            rangeMech = 100;
        }
        else if (mechNum == 2)
        {
            rangeMech = 150;
        }
        else if (mechNum == 3)
        {
            rangeMech = 200;
        }
        else
        {
            rangeMech = 0;

            Debug.Log("Error handler");
        }

        return rangeMech;
    }

    public float GetRegen(int mechNum)
    {
        if (mechNum == 1)
        {
            regenMech = 10f;
        }
        else if (mechNum == 2)
        {
            regenMech = 10f;
        }
        else if (mechNum == 3)
        {
            regenMech = 7f;
        }
        else
        {
            regenMech = 0f;

            Debug.Log("Error handler");
        }

        return regenMech;
    }

    public float GetFireRate(int mechNum)
    {
        if (mechNum == 1)
        {
            fireRateMech = 1f;
        }
        else if (mechNum == 2)
        {
            regenMech = 10f;
        }
        else if (mechNum == 3)
        {
            regenMech = 7f;
        }
        else
        {
            regenMech = 0f;

            Debug.Log("Error handler");
        }

        return fireRateMech;
    }

    public float GetAgility(int charNum)
    {
        if (charNum == 1)
        {
            agilityChar = 1f;
        }
        else if (charNum == 2)
        {
            agilityChar = 0.5f;
        }
        else if (charNum == 3)
        {
            agilityChar = 2f;
        }
        else
        {
            agilityChar = 0f;

            Debug.Log("Error handler");
        }

        return agilityChar;
    }

    public float GetDefense(int charNum)
    {
        if (charNum == 1)
        {
            defenseChar = 1f;
        }
        else if (charNum == 2)
        {
            defenseChar = 2f;
        }
        else if (charNum == 3)
        {
            defenseChar = 0.5f;
        }
        else
        {
            defenseChar = 0f;

            Debug.Log("Error handler");
        }

        return defenseChar;
    }

    public float GetStrength(int charNum)
    {
        if (charNum == 1)
        {
            strengthChar = 1f;
        }
        else if (charNum == 2)
        {
            strengthChar = 1.5f;
        }
        else if (charNum == 3)
        {
            strengthChar = 2f;
        }
        else
        {
            strengthChar = 0f;

            Debug.Log("Error handler");
        }

        return strengthChar;
    }

    public float GetDexterity(int charNum)
    {
        if (charNum == 1)
        {
            dexterityChar = 1f;
        }
        else if (charNum == 2)
        {
            dexterityChar = 1.25f;
        }
        else if (charNum == 3)
        {
            dexterityChar = 0.75f;
        }
        else
        {
            dexterityChar = 0f;

            Debug.Log("Error handler");
        }

        return dexterityChar;
    }

    public float GetRepair(int charNum)
    {
        if (charNum == 1)
        {
            repairChar = 1f;
        }
        else if (charNum == 2)
        {
            repairChar = 1.25f;
        }
        else if (charNum == 3)
        {
            repairChar = 1f;
        }
        else
        {
            repairChar = 0f;

            Debug.Log("Error handler");
        }

        return repairChar;
    }
}

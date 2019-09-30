using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy one, two, three;
        one = new Enemy();
        two = new Enemy();
        three = new Enemy();

        Debug.Log(one + "\n" + two + "\n" + three);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Enemy
{
    private string name;
    private float health, armor, damage;
    private static long numEnemy = 0;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
    
    public float Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public float Armor
    {
        get
        {
            return armor;
        }

        set
        {
            armor = value;
        }
    }

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    public Enemy()
    {
        name = "Enemy" + numEnemy++.ToString();
        health = 100f * (float)numEnemy;
        armor = 50f * (float)numEnemy;
        damage = 75f * (float)numEnemy;
    }

    public Enemy(string name, float health, float armor, float damage)
    {
        numEnemy++;
        this.name = name;
        this.health = health;
        this.armor = armor;
        this.damage = damage;
    }

    public override string ToString()
    {
        return "Name: " + name + ", Health: " + health + ", Armor: " + armor + ", Damage: " + damage;
    }
}
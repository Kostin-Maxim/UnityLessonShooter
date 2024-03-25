using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health = 3;
    // Start is called before the first frame update
    public void Hurt(int damage)
    { 
        health -= damage;
        Debug.Log("Health: " +  health);
    }
}

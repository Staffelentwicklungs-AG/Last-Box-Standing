using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEntity", menuName = "ScriptableObjects", order = 1)]
public class  IDontKnowYet: ScriptableObject
{
    // Lets call it some Entity
    // Scriptable Object
    // to later instantiate several players
    // and to intantiate enemy entities
    public string entityName;
    public int health;
    public float movementSpeed;
    // Other stats that depend on equipment
    // damage will depend on weapons
    // armour is self explanitory
    // i couldn't come up with anything else yet
    public Dictionary<string, bool> equipment;
    public Dictionary<string, float> Items;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

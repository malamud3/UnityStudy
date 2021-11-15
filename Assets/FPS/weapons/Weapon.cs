using UnityEngine;

[System.Serializable]
public class Weapon 
{
    //ganaric
    public string name = "Glock";
    public int damage = 10;
    public float range = 100f;
    public GameObject graphics;
    internal bool enabled;
}
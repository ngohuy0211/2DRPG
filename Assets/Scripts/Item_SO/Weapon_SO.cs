using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "weapon", menuName = "Item/Weapon")]
public class Weapon_SO : BaseItem_SO
{
    public int MinDamage;
    public int MaxDamage;

    [Range(0f, 1f)]
    public float CriticalChance;
    public float CriticalDamageMultiplier;

    public Weapon_SO()
    {
        Stackable = false;
        Equipable = true;
    }

}

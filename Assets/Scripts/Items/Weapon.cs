using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : BaseItem
{
    public int MinDamage;
    public int MaxDamage;

    [Range(0f, 1f)]
    public float CriticalChance;
    public float CriticalDamageMultiplier;

    public Weapon_SO Data;


    private void Start()
    {
        DisplayName = Data.DisplayName;
        Description = Data.Description;
        Stackable = Data.Stackable;
        Equipable = Data.Equipable;

        MinDamage = Data.MinDamage;
        MaxDamage = Data.MaxDamage;
        CriticalChance = Data.CriticalChance;
        CriticalDamageMultiplier = Data.CriticalDamageMultiplier;
    }
    public override void Use()
    {
        //TODO: Trang bi vu khi

        
    }
}

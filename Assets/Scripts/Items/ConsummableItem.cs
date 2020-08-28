using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsummableItem : BaseItem
{
    public enum ConsummableType
    {
        HPRegen,
        MPRegen
    }

    public ConsummableType ItemType;
    public int Value;  // Gia tri thu duoc khi su dung item nay
    public ConsummableItem_SO Data;

    private void Start()
    {
        DisplayName = Data.DisplayName;
        Description = Data.Description;
        Stackable = Data.Stackable;
        Equipable = Data.Equipable;

        ItemType = Data.ItemType;
        Value = Data.Value;
    }

    public override void Use()
    {
        switch(ItemType)
        {
            case ConsummableType.HPRegen:
                //TODO: Hoi mau
                break;
            case ConsummableType.MPRegen:
                //TODO: Hoi mana
                break;
        }
    }
}

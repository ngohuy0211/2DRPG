using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem_SO : ScriptableObject
{
    public GameObject ItemPref;
    public string DisplayName;
    public string Description;

    public bool Stackable;
    public bool Equipable;

}

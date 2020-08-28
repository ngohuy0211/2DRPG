using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseItem : MonoBehaviour
{
    public string DisplayName;
    public string Description;

    public bool Stackable;
    public bool Equipable;

    public int Amount;

    public abstract void Use();

}

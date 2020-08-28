using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Consummable Item")]
public class ConsummableItem_SO : BaseItem_SO
{
    public ConsummableItem.ConsummableType ItemType;
    public int Value;  // Gia tri thu duoc khi su dung item nay

    public ConsummableItem_SO()
    {
        Stackable = true;
        Equipable = false;
    }
}

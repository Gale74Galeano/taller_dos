using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Equip card", menuName = "Equip_Card")]

public class Card_equip : ScriptableObject
{
    public string cardName;
    public string rare;
    public int costPoints;
    public int atackPoints;
    public int resistance;
    public string affinity;
}

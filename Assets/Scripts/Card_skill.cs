using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Skill card", menuName = "Skill_Card")]

public class Card_skill : ScriptableObject
{
    public string cardName;
    public string rare;
    public int costPoints;
    public string effectType;
    public string effectPoints;
}

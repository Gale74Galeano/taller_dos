using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new character card", menuName = "Char_Card")]
public class Card_char : ScriptableObject
{
    public string cardName;
    public string rare;
    public int costPoints;
    public int atackPoints;
    public int resistance;
    public string affinity;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baraja : MonoBehaviour
{
    [Header("Cartas disponibles")]
    [SerializeField]
    Card_char[] availableCharactersCards;
    [SerializeField]
    Card_equip[] availableEquipCards;
    [SerializeField]
    Card_equip[] availableSkillCards;
}

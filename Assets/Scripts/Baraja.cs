using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baraja : MonoBehaviour
{
    [Header("Cartas disponibles")]
    [SerializeField]
    public Card_char[] availableCharactersCards;
    [SerializeField]
    public Card_equip[] availableEquipCards;
    [SerializeField]
    public Card_skill[] availableSkillCards;

    private void Start()
    {
        PrintCards();
    }

    void PrintCards()
    {
        string characters = "Character Cards: \n\nCardName // Rare // CostPoints // AtackPoints // Resistance // Affinity\n\n";
        for (int i = 0; i < availableCharactersCards.Length; i++)
        {
            characters += availableCharactersCards[i].cardName + ": // " + availableCharactersCards[i].rare + " // " + availableCharactersCards[i].costPoints + " // " + availableCharactersCards[i].atackPoints + " // " + availableCharactersCards[i].resistance + " // " + availableCharactersCards[i].affinity + "\n" + "____________________________________________________________________________" + "\n";
        }
        Debug.Log(characters);

        string equip = "Equip Cards: \n\nCardName // Rare // CostPoints // AtackPoints // Resistance // Affinity\n\n";
        for (int i = 0; i < availableEquipCards.Length; i++)
        {
            equip += availableEquipCards[i].cardName + ": // " + availableEquipCards[i].rare + " // " + availableEquipCards[i].costPoints + " // " + availableEquipCards[i].atackPoints + " // " + availableEquipCards[i].resistance + " // " + availableEquipCards[i].affinity + "\n" + "____________________________________________________________________________" + "\n";
        }
        Debug.Log(equip);

        string skill = "Skill Cards: \n\nCardName // Rare // CostPoints // EffectType // EffectPoints\n\n";
        for (int i = 0; i < availableSkillCards.Length; i++)
        {
            skill += availableSkillCards[i].cardName + ": // " + availableSkillCards[i].rare + " // " + availableSkillCards[i].costPoints + " // " + availableSkillCards[i].effectType + " // " + availableSkillCards[i].effectPoints + "\n" + "____________________________________________________________________________" + "\n";
        }
        Debug.Log(skill);
    }
    //public Card_char BuyCharacterCardByName(string cardName)
    //{
    //    Card_char character = new Card_char();
    //    foreach (Card_char item in availableCharactersCards)
    //    {
    //        if (item.cardName == cardName)
    //        {
    //            character = item;
    //        }
    //    }

    //    if (string.IsNullOrEmpty(character.cardName))
    //    {
    //        return null;
    //    }
    //    return character;
    //}

    //public Card_equip BuyEquipCardByName(string cardName)
    //{
    //    Card_equip equip = new Card_equip();
    //    foreach (Card_equip item in availableEquipCards)
    //    {
    //        if (item.cardName == cardName)
    //        {
    //            equip = item;
    //        }
    //    }

    //    if (string.IsNullOrEmpty(equip.cardName))
    //    {
    //        return null;
    //    }
    //    return equip;
    //}

    //public Card_skill BuySkillCardByName(string cardName)
    //{
    //    Card_skill skill = new Card_skill();
    //    foreach (Card_skill item in availableSkillCards)
    //    {
    //        if (item.cardName == cardName)
    //        {
    //            skill = item;
    //        }
    //    }

    //    if (string.IsNullOrEmpty(skill.cardName))
    //    {
    //        return null;
    //    }
    //    return skill;
    //}
}

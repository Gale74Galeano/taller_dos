using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card_char> myCharactersCards;
    public List<Card_equip> myEquipCards;
    public List<Card_skill> mySkillCards;
    //

    public Card_char GetCharacterCardByName(string cardName)
    {
        Card_char character = new Card_char();
        foreach (Card_char item in myCharactersCards)
        {
            if (item.cardName == cardName)
            {
                character = item;
            }
        }

        if(string.IsNullOrEmpty(character.cardName))
        {
            return null;
        }
        return character;
    }

    public Card_equip GetEquipCardByName(string cardName)
    {
        Card_equip equip = new Card_equip();
        foreach (Card_equip item in myEquipCards)
        {
            if (item.cardName == cardName)
            {
                equip = item;
            }
        }

        if (string.IsNullOrEmpty(equip.cardName))
        {
            return null;
        }
        return equip;
    }

    public Card_skill GetSkillCardByName(string cardName)
    {
        Card_skill skill = new Card_skill();
        foreach (Card_skill item in mySkillCards)
        {
            if (item.cardName == cardName)
            {
                skill = item;
            }
        }

        if (string.IsNullOrEmpty(skill.cardName))
        {
            return null;
        }
        return skill;
    }
}

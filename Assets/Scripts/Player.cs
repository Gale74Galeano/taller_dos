using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    [SerializeField]
    Baraja allCards;

    [SerializeField]
    public Deck deck;

    [SerializeField] TMP_InputField cardName;
    [SerializeField] TMP_Text costPointsText;

    public int costPoints = 40;

    private void Start()
    {
        UpdatePoints();
    }

    void UpdatePoints()
    {
        costPointsText.text = "Cost Points: " + costPoints.ToString();
    }
    public void BuyCard()
    {

        //char
        if (string.IsNullOrEmpty(cardName.text)) return;

        Card_char[] charCards= allCards.availableCharactersCards;
        for (int i = 0; i < charCards.Length; i++)
        {
            if(cardName.text== charCards[i].cardName)
            {
                Card_char newCard = new Card_char();
                newCard = charCards[i];
                if(costPoints>= newCard.costPoints)
                {
                    deck.myCharactersCards.Add(newCard);
                    costPoints -= newCard.costPoints;
                    UpdatePoints();
                }
                else
                {
                    Debug.Log("No tienes suficientes Cost Points");
                }
                return;

            }
        }

        //equip

        Card_equip[] equipCards = allCards.availableEquipCards;
        for (int i = 0; i < equipCards.Length; i++)
        {
            if (cardName.text == equipCards[i].cardName)
            {
                Card_equip newCard = new Card_equip();
                newCard = equipCards[i];
                if (costPoints >= newCard.costPoints)
                {
                    deck.myEquipCards.Add(newCard);
                    costPoints -= newCard.costPoints;
                    UpdatePoints();
                }
                else
                {
                    Debug.Log("No tienes suficientes Cost Points");
                }
                return;

            }
        }


        //skill

        Card_skill[] skillCards = allCards.availableSkillCards;
        for (int i = 0; i < skillCards.Length; i++)
        {
            if (cardName.text == skillCards[i].cardName)
            {
                Card_skill newCard = new Card_skill();
                newCard = skillCards[i];
                if (costPoints >= newCard.costPoints)
                {
                    deck.mySkillCards.Add(newCard);
                    costPoints -= newCard.costPoints;
                    UpdatePoints();
                }
                else
                {
                    Debug.Log("No tienes suficientes Cost Points");
                }
                return;

            }
        }
    }
}

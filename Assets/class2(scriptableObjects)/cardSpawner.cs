using ScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardSpawner : MonoBehaviour
{
    [SerializeField] private CardDisplay cardDisplayPrefab;
    [SerializeField] private List<CardInfo> cards;
    [SerializeField] private DeckInfo deck;

    private void Start()
    {
        deck = Instantiate(deck);

        for (int i = 0; i < deck.cards.Count; i++)
        {
            deck.cards[i] = Instantiate(deck.cards[i]);
            CardDisplay spawnedCard = Instantiate(cardDisplayPrefab, transform);
            spawnedCard.SetCardInfo(Instantiate(deck.cards[i]));
        }
    }

}

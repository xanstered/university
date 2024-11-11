using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DeckInfo", menuName = "My Game/DeckInfo")]

public class DeckInfo : ScriptableObject
{
    public string deckName;
    public List<CardInfo> cards = new();
}

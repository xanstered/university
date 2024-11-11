using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardInfo", menuName = "My Game/CardInfo")]

public class CardInfo : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int manaCost = 1;
    public int health = 1;
    public Sprite cardImage;
}
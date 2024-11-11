using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace ScriptableObjects
{
    public class CardDisplay : MonoBehaviour
    {
        [SerializeField] private CardInfo cardInfo;

        [SerializeField] private TextMeshProUGUI nameLabel;
        [SerializeField] private TextMeshProUGUI descriptionLabel;
        [SerializeField] private TextMeshProUGUI manaCostLabel;
        [SerializeField] private TextMeshProUGUI healthLabel;
        [SerializeField] private Image imageLabel;

        public void SetCardInfo(CardInfo cardInfo)
        {
            nameLabel.text = cardInfo.cardName;
            descriptionLabel.text = cardInfo.cardDescription;
            manaCostLabel.text = $"Mana cost: {cardInfo.manaCost}";
            healthLabel.text = $"Health: {cardInfo.health}";
            imageLabel.sprite = cardInfo.cardImage;
        }

    }
}

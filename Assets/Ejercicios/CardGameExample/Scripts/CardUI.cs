using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Example.CardGame
{
	public class CardUI : MonoBehaviour
	{
		[SerializeField] private Image background;
		[SerializeField] private TextMeshProUGUI costText;
		[SerializeField] private TextMeshProUGUI strengthText;
		[SerializeField] private TextMeshProUGUI nameText;

		[SerializeField] private Card testCard;
		[SerializeField] private Button button;

		private Card card;

		private void Awake()
		{
			button.onClick.AddListener(OnClicked);
		}
		private void OnDestroy()
		{
			button.onClick.RemoveListener(OnClicked);
		}

		[ContextMenu("Test Card")]
		public void SetData()
		{
			SetData(testCard);
		}
		public void SetData(Card card)
		{
			this.card = card;
			costText.SetText(card.Cost.ToString());
			strengthText.SetText(card.Strength.ToString());
			nameText.SetText(card.Name.ToUpper());
		}

		private void OnClicked()
		{
			//TODO: Play the card here though the PlayerController class. ex: controller.Play(card)
		}
	}
}
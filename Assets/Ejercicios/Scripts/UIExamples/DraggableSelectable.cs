using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Example
{
	[RequireComponent(typeof(Selectable))]
	[RequireComponent(typeof(RectTransform))]
	public class DraggableSelectable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		private Canvas canvas;
		private RectTransform rectTransform;
		private Selectable selectable;
		private Vector2 initialPosition;

		private void Awake()
		{
			canvas = GetComponentInParent<Canvas>();
			rectTransform = GetComponent<RectTransform>();
			selectable = GetComponent<Selectable>();
		}
		
		public void OnBeginDrag(PointerEventData eventData)
		{
			selectable.image.raycastTarget = false;
			initialPosition = rectTransform.anchoredPosition;
		}
		public void OnDrag(PointerEventData eventData)
		{
			rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
		}
		public void OnEndDrag(PointerEventData eventData)
		{
			GameObject other = eventData.pointerCurrentRaycast.gameObject;
			selectable.image.raycastTarget = true;
			if (other == null)
			{
				rectTransform.anchoredPosition = initialPosition;
				return;
			}

			DraggableTarget target = other.GetComponent<DraggableTarget>();
			if (target == null)
			{
				rectTransform.anchoredPosition = initialPosition;
				return;
			}
			
			target.SetTarget(this);
		}

	}
	
}

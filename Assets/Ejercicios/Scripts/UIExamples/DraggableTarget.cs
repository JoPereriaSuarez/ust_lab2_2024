using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Example
{
	[RequireComponent(typeof(Image))]
	public class DraggableTarget : MonoBehaviour
	{
		[SerializeField] private RectTransform buttonsParent;

		public void SetTarget(DraggableSelectable target)
		{
			target.transform.parent = buttonsParent;
		}
	}
	
}

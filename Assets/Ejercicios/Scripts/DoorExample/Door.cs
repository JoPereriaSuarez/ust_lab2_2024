using System;
using UnityEngine;

/* Serializable hace que esta clase se vea en el inspector de Unity
 * Esto solo se aplica a clases que no heredan MonoBehaviour
 */
[Serializable]
public class Door
{
	[SerializeField] private string id;

	private bool isOpen;

	public void ToggleOpen()
	{
		if (isOpen)
		{
			Close();
		}
		else
		{
			Open();
		}
	}
	private void Open()
	{
		Debug.Log($"The door {id} opens");
		isOpen = true;
	}

	private void Close()
	{
		Debug.Log($"The door {id} close");
		isOpen = false;
	}
}
using UnityEngine;

public class House : MonoBehaviour
{
	[SerializeField] private Door entryDoor;
	[SerializeField] private Door roomDoor;

	[ContextMenu(nameof(ToggleEntryDoor))]
	public void ToggleEntryDoor()
	{
		if (entryDoor == null)
		{
			Debug.Log("Entry door is null");
			return;
		}
		entryDoor.ToggleOpen();
	}
	[ContextMenu(nameof(ToggleRoomDoor))]
	public void ToggleRoomDoor()
	{
		if (roomDoor == null)
		{
			Debug.Log("Room door is null");
			return;
		}
		roomDoor.ToggleOpen();
	}
}


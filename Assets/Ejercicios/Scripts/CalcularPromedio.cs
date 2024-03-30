using Unity.VisualScripting;
using UnityEngine;

public class CalcularPromedio : MonoBehaviour
{
	// SerializeField hace que la variable se vea en el inspector de unity
	[SerializeField] private float[] notas;

	// ContextMenu hace que esta función se pueda llamar desde el menú contextual del inspector
	[ContextMenu(nameof(Calcular))]
	public void Calcular()
	{
		if (notas == null || notas.Length == 0)
		{
			Debug.Log("No hay notas para calcular el promedio");
			return;
		}
		
		float resultado = 0f;
		for (int i = 0; i < notas.Length; i++)
		{
			resultado += notas[i];
		}

		resultado /= notas.Length;
		Debug.Log($"El promedio es {resultado}");
	}
}
using UnityEngine;

public class EliminarEspaciosEnBlaco : MonoBehaviour
{
	[SerializeField] private string texto;

	[ContextMenu(nameof(SinEspaciosEnBlancos))]
	public void SinEspaciosEnBlancos()
	{
		if (string.IsNullOrEmpty(texto))
		{
			Debug.Log("El texto ingresado es nulo o vacío");
			return;
		}
		string[] split = texto.Split(' ');
		string resultado = string.Empty;

		for (int i = 0; i < split.Length; i++)
		{
			resultado += split[i];
		}
		
		Debug.Log($"{texto} sin espacios es: {resultado}");
	}
}
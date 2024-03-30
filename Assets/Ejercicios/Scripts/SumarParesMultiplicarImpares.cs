using UnityEngine;

public class SumarParesMultiplicarImpares : MonoBehaviour
{
	[SerializeField] private int[] numeros;

	[ContextMenu(nameof(Calcular))]
	public void Calcular()
	{
		if (numeros == null || numeros.Length == 0)
		{
			Debug.Log("No hay numeros para hacer esta operación");
			return;
		}
		int suma = 0;
		int multiplicacion = 0;

		for (int i = 0; i < numeros.Length; i++)
		{
			// El modulo (%) es el operador que calcula el resto de una division
			if (numeros[i] % 2 == 0)
			{
				suma += numeros[i];
			}
			else
			{
				if (multiplicacion == 0)
					multiplicacion = 1;
				
				multiplicacion *= numeros[i];
			}
		}
		
		Debug.Log($"La suma de los pares es {suma}. La multiplicacion de los impares es {multiplicacion}");
	}
}
using UnityEngine;

public class Cofre : MonoBehaviour
{
    [Header("Prefab del botín")]
    public GameObject monedaPrefab;

    [Header("Ajustes")]
    public int cantidadMonedas = 5;

    private bool yaFueAbierto = false;

    private void OnMouseDown()
    {
        if (yaFueAbierto) return;

        yaFueAbierto = true;
        StartCoroutine(AbrirCofre());
    }

    private System.Collections.IEnumerator AbrirCofre()
    {
        Debug.Log("Cofre abierto!");

        yield return new WaitForSeconds(1.0f);

        for (int i = 0; i < cantidadMonedas; i++)
        {
            Instantiate(monedaPrefab, transform.position + Vector3.up * 1f, Quaternion.identity);

            yield return new WaitForSeconds(0.2f);
        }

        Debug.Log("Botín completado!");
    }
}
using System.Collections;
using UnityEngine;

public class CofreDelTesoro : MonoBehaviour
{
    public GameObject monedaPrefab;

    private bool yaFueAbierto = false;

    private void OnMouseDown()
    {
        if (yaFueAbierto)
            return;

        yaFueAbierto = true;
        StartCoroutine(AbrirCofre());
    }

    private IEnumerator AbrirCofre()
    {
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 5; i++)
        {
            Instantiate(monedaPrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(0.2f);
        }
    }
}
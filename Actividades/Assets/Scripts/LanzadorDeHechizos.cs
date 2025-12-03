using UnityEngine;

public class LanzadorDeHechizos : MonoBehaviour
{
    public DatosHechizo hechizo;

    private void Start()
    {
        if (hechizo != null)
        {
            Debug.Log($"Hechizo preparado: {hechizo.nombre}");
            Debug.Log($"Coste de maná: {hechizo.costeMana}");
            Debug.Log($"Daño del hechizo: {hechizo.dano}");
            Debug.Log($"Descripción: {hechizo.descripcion}");
        }
        else
        {
            Debug.LogWarning("No hay un hechizo asignado en el Inspector.");
        }
    }
}

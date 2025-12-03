using UnityEngine;

[CreateAssetMenu(fileName = "NuevoHechizo", menuName = "Hechizos/Nuevo Hechizo")]
public class DatosHechizo : ScriptableObject
{
    [Header("Información del Hechizo")]
    public string nombre;

    public int costeMana;
    public int dano;

    [TextArea(2, 5)]
    public string descripcion;
}
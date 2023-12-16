using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    private TextMeshPro label;
    private Vector2Int coordinate;

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinate();
    }

    void Update()
    {
        if (!Application.isPlaying) DisplayCoordinate();
        UpdateTileName();
    }

    void DisplayCoordinate()
    {
        coordinate.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinate.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        label.text = coordinate.ToString();
    }

    void UpdateTileName()
    {
        transform.parent.name = label.text;
    }
}

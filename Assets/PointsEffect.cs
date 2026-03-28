using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatingText : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float lifetime = 1.5f;

    public TextMeshProUGUI textMesh;
    private Color startColor;
    private float timer;

    void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        startColor = textMesh.color;
    }

    public void SetText(string text)
    {
        textMesh.text = text;
    }

    void Update()
    {
        transform.position += Vector3.up * floatSpeed * Time.deltaTime;

        // Fade out over time
        timer += Time.deltaTime;
        float t = timer / lifetime;

        Color c = startColor;
        c.a = Mathf.Lerp(1f, 0f, t);
        textMesh.color = c;

        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
}

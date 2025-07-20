using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer targetRenderer;      // Об'єкт із матеріалом
    [SerializeField] private float changeInterval = 2f;
    [SerializeField] private float lerpSpeed = 2f;

    // масив кольорів треба походу тут

    private readonly Color[] rainbowColors = new Color[]
    {
        Color.red,
        Color.yellow,
        Color.green,
        Color.blue,
        Color.cyan,
        new Color(0.56f, 0f, 1f),
        new Color(1f, 0.5f, 0f), // orange 

    };
    private void Start()
    {
        if (targetRenderer == null)
        {
            Debug.LogError("targetRenderer не призначено!");
            return;
        }

        StartCoroutine(ChangeColorRainbow());
    }

    private IEnumerator ChangeColorRainbow()
    {
        int currentIndex = 0;

        while (true)
        {
            Color startColor = targetRenderer.material.GetColor("_BaseColor");
            Color targetColor = rainbowColors[(currentIndex + 1) % rainbowColors.Length];
            float t = 0f;

            while (t < 1f)
            {
                t += Time.deltaTime * lerpSpeed;
                Color lerped = Color.Lerp(startColor, targetColor, t);
                targetRenderer.material.SetColor("_BaseColor", lerped); // URP Lit Shader
                yield return null;
            }

            yield return new WaitForSeconds(changeInterval);
            currentIndex = (currentIndex + 1) % rainbowColors.Length;
        }
    }
}
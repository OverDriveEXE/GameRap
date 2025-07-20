using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Image targetImage;        // Посилання на Image
    [SerializeField] private float changeInterval = 2f;
    [SerializeField] private float lerpSpeed = 2f;

    private void Start()
    {
        if (targetImage == null)
        {
            Debug.LogError("targetImage не призначено!");
            return;
        }

        StartCoroutine(ChangeColorSmoothly());
    }

    private IEnumerator ChangeColorSmoothly()
    {
        while (true)
        {
            Color startColor = targetImage.color;
            Color targetColor = GetRandomColor();
            float t = 0f;

            while (t < 1f)
            {
                t += Time.deltaTime * lerpSpeed;
                targetImage.color = Color.Lerp(startColor, targetColor, t);
                yield return null;
            }

            yield return new WaitForSeconds(changeInterval);
        }
    }

    private Color GetRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
    }
}
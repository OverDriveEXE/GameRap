using UnityEngine;
using UnityEngine.UI;

public class RainbowButton : MonoBehaviour
{
    private Image buttonImage;
    private float hue;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        hue = 0f;
    }

    void Update()
    {
        hue += Time.deltaTime * 0.2f; // швидкість переливання
        if (hue > 1f) hue = 0f;

        Color rainbowColor = Color.HSVToRGB(hue, 1f, 1f);
        buttonImage.color = rainbowColor;
    }
}
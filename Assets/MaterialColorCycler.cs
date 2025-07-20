using UnityEngine;

public class MaterialColorCycler : MonoBehaviour
{
    [SerializeField] private Material targetMaterial;
    [SerializeField] private float colorChangeSpeed = 1f;
    [SerializeField] private bool affectEmission = true;
    [SerializeField] private float[] colorPhases = new float[] { 0f, 2f, 4f };

    private float GetNormalizedSin(float time, float phase)
    {
        return Mathf.Sin(time + phase) * 0.5f + 0.5f;
    }

    private void Update()
    {
        float time = Time.time * colorChangeSpeed;

        float r = GetNormalizedSin(time, colorPhases[0]);
        float g = GetNormalizedSin(time, colorPhases[1]);
        float b = GetNormalizedSin(time, colorPhases[2]);

        Color dynamicColor = new Color(r, g, b);

        targetMaterial.color = dynamicColor;

        if (affectEmission) 
        {
            targetMaterial.SetColor("_EmissionColor", dynamicColor * 2f);
        }
    }



}

using UnityEngine;

public class MaterialColorCycler : MonoBehaviour
{
    public Material targetMaterial;
    public float colorChangeSpeed = 1f;
    public bool affectEmission = true;

    private void Update()
    {
        float r = Mathf.Sin(Time.time * colorChangeSpeed) * 0.5f + 0.5f;
        float g = Mathf.Sin(Time.time * colorChangeSpeed + 2f) * 0.5f + 0.5f;
        float b = Mathf.Sin(Time.time * colorChangeSpeed + 4f) * 0.5f + 0.5f;

        Color dynamicColor = new Color(r, g, b);

        targetMaterial.color = dynamicColor;

        if (affectEmission) 
        {
            targetMaterial.SetColor("_EmissionColor", dynamicColor * 2f);
        }
    }



}

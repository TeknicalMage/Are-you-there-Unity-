using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    [SerializeField]
    private List<Renderer> renderers;

    private Color colorValue = Color.white;

    private List<Material> materials;
    private Color startColor;
    public bool acquiredDefaultColor = false;
    public void ToggleHighlight(bool val, GameObject target) {
        
        Renderer m_ObjectRenderer = target.GetComponent<Renderer>();


        if(!acquiredDefaultColor)
        {
            startColor = m_ObjectRenderer.material.color;
            acquiredDefaultColor = true;
        }

        if (val) {

            print(m_ObjectRenderer.material.color);
            Color customColor = new Color(0.7f, 0.7f, 1f, 0.5f);
            customColor.a = 0.1f;
            m_ObjectRenderer.material.SetColor("_Color", customColor);
        } else {
            m_ObjectRenderer.material.SetColor("_Color", startColor);
        }
    }
}

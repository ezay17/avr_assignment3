using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Color newColor = Color.red;
    
    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        // Überprüfen, ob das GameObject ein Renderer hat.
        if (renderer != null)
        {
            // Erstellen Sie ein neues Material, um die Farbänderung zu ermöglichen.
            Material material = new Material(renderer.material);
            material.color = newColor;

            // Weisen Sie das neue Material dem Renderer zu.
            renderer.material = material;
        }
        else
        {
            Debug.LogError("Das GameObject enthält keinen Renderer-Komponente.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator FadeOut()
    {
        Color c = GetComponent<Renderer>().material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            GetComponent<Renderer>().material.color = c;
            // The yield return null line is the point where execution pauses and resumes in the following frame.
            yield return null;
        }
    }
}

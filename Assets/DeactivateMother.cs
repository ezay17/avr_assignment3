using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DeactivateMother : MonoBehaviour
{
    public GameObject mother;

    public GameObject daughter;

    public GameObject grandmother;

    public GameObject prefabToInstantiate;
    // Start is called before the first frame update
    void Start()
    {
        // wenn aktiv -> ansonsten im Inspector zuweisen!
        //_mother = GameObject.FindGameObjectWithTag("Mother");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Deaktiviere Mutter"))
        {
            mother.SetActive(false);
            debugDaugherStatus();
        }
        
        if (GUILayout.Button("Aktiviere Mutter"))
        {
            mother.SetActive(true);
            debugDaugherStatus();
        }

        if (GUILayout.Button("Lösche Oma"))
        {
            Destroy(grandmother);
        }

        if (GUILayout.Button("Spawne Oma, Mutter und Tochter"))
        {
            if (prefabToInstantiate != null)
            {
                Vector3 spawnPosition = new Vector3(1.0f, 0.0f, 0.0f);
                Quaternion spawnRotation = Quaternion.identity;
                GameObject newPrefabInstance = Instantiate(prefabToInstantiate, spawnPosition, spawnRotation);
            }
        }
    }

    private void debugDaugherStatus()
    {
        Debug.Log("activeSelf: " + daughter.activeSelf);
        Debug.Log("activeInHierarchy: " + daughter.activeInHierarchy);
    }
}

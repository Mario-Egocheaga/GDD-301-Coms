using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour
{
    public List<GameObject> levelSections = new List<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (GameObject level in levelSections)
            {
                level.SetActive(true);
            }

            Destroy(gameObject);
        }
    }
}

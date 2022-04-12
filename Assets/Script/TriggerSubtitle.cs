using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSubtitle : MonoBehaviour
{
    public string subText;
    public string subText2;

    public bool secondText;

    public float delay;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI.instance.SetSubtitle(subText, delay);

            if (secondText)
            {
                StartCoroutine(Encouragement());
            }

        }
    }

    private IEnumerator Encouragement()
    {
        yield return new WaitForSeconds(delay + 3f);
        UI.instance.SetSubtitle(subText2, delay);

    }
}

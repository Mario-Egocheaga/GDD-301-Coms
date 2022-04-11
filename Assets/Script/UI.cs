//https://www.youtube.com/watch?v=Wu46UAVlFL4 Used this cause couldn't be bothered to think of a creative subtitle solution.

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI subtitleText = default;

    public static UI instance;

    void Awake()
    {
        instance = this;
        ClearSub();
    }

    public void SetSubtitle(string subtitle, float delay)
    {
        subtitleText.text = subtitle;

        StartCoroutine(Clear(delay));
    }

    public void ClearSub()
    {
        subtitleText.text = "";
    }

    private IEnumerator Clear(float delay)
    {
        yield return new WaitForSeconds(delay);
        ClearSub();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class WavesUI : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        WavesManager.instance.onChanged.AddListener(RefreshText);
    }

    void RefreshText()
    {
        text.text = "Remaining Waves: " + WavesManager.instance.waves.Count;
    }
}



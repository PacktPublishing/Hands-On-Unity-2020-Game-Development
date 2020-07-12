using UnityEngine;
using UnityEngine.UI;

public class PlayerBulletsUI : MonoBehaviour
{
    Text text;

    public PlayerShooting targetShooting;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Bullets: " + targetShooting.bulletsAmount;
    }
}


using UnityEngine;
using UnityEngine.UI;

public class HealthBarControl : MonoBehaviour
{

    [SerializeField] private Image fillImage;

    void Update()
    {
        if(GetComponent<Slider>().value > GetComponent<Slider>().maxValue / 2)
        {
            fillImage.color = Color.green;
        }
        if (GetComponent<Slider>().value <= GetComponent<Slider>().maxValue / 2)
        {
            fillImage.color = Color.yellow;
        }
        if (GetComponent<Slider>().value <= GetComponent<Slider>().maxValue / 3)
        {
            fillImage.color = Color.red;
        }
    }
}

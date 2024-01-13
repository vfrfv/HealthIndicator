using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBar : HealthBar
{
    protected override void Fill(float currentValue)
    {
        _slider.value = currentValue;
    }
}

using UnityEngine;
using UnityEngine.UI;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _health.Changed += Fill;
    }

    private void OnDisable()
    {
        _health.Changed -= Fill;
    }

    protected abstract void Fill(float currentValue);

}

using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Player _health;

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

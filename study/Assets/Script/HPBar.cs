using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    Animator animator;
    [SerializeField] public float health;
    [SerializeField] float maxHelath;
    [SerializeField] Slider slider;
    bool isDead = false;
    private void Start()
    { 
        animator = GetComponent<Animator>();
        health = maxHelath;
        UpdateUI();
    }

    private void Update()
    {
        if(health <=0)
            isDead = true;

    }

    public void Damage(float attack)
    {
        if (isDead)
            return;
        health -= attack;
        UpdateUI();
        if (health <= 0)
        {
            animator.SetTrigger("7");
        }
    }

    public void UpdateUI()
    {
        slider.value = health / maxHelath;
    }
}

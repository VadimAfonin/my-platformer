using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private Animator anim;

    private float currentHealth;
    private bool isDeath;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = _maxHealth;
        isDeath = false;
    }    

    public void GetDamage(float damage)
    {
        currentHealth -= damage;
        CheckDeath();
    }

    private void CheckDeath()
    {
        if (currentHealth < 0)
        {
            isDeath = false;
        }
        else
        {
            isDeath = true;
            anim.SetBool("isDeath", true);
        }
    }
}

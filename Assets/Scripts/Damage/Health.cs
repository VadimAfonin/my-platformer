using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private Image _playerHealthImage;
    [SerializeField] private GameObject _deathCanvas;
    [SerializeField] private GameObject _GameCanvas;

    private Animator anim;

    public float currentHealth;
    public static bool isDeath;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = _maxHealth;
        isDeath = false;
    }    

    public void GetDamage(float damage)
    {
        if (gameObject.name.Equals("Player"))
        {
            currentHealth -= damage;
            _playerHealthImage.fillAmount = currentHealth / _maxHealth;
            CheckPlayerDeath();
        }
        else
        {
            currentHealth -= damage;
            CheckDeath();
        }
    }

    private void CheckDeath()
    {
        if (currentHealth > 0)
        {
            isDeath = false;
        }
        else
        {
            isDeath = true;
            anim.SetBool("isDeath", true);
            Destroy(gameObject, 3);
            Statistics._enemiesKilled++;
        }
    }    

    private void CheckPlayerDeath()
    {
        if (currentHealth > 0)
        {
            isDeath = false;
        }
        else
        {
            isDeath = true;
            anim.SetBool("isDeath", true);
            StartCoroutine(waitForAnimation());
        }        
    }

    IEnumerator waitForAnimation()
    {
        yield return new WaitForSecondsRealtime(2.0f);

        _GameCanvas.SetActive(false);
        Time.timeScale = 0.1f;
        _deathCanvas.SetActive(true);
    }    
}

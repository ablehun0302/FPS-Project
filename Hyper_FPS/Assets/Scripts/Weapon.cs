using UnityEngine;
using StarterAssets;
public class Weapon : MonoBehaviour
{
    [SerializeField] int damageAmount = 1;

    StarterAssetsInputs starterAssetsInputs;

    void Awake()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
    }
    void Update()
    {
        HandleShoot();
    }

    void HandleShoot()
    {
        if (!starterAssetsInputs.Shoot) return;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {   
            Debug.Log(hit.collider.name);  
            /*
            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
            enemyHealth?.TakeDamage(damageAmount);
            //if (enemyHealth != null)
            //{
            //    enemyHealth.TakeDamage(damageAmount);
            //}
            starterAssetsInputs.ShootInput(false);
            */
        }
    }
}
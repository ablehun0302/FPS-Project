using UnityEngine;
using StarterAssets;
public class Weapon : MonoBehaviour
{
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] int damageAmount = 1;

    StarterAssetsInputs starterAssetsInputs;

    void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }
    void Update()
    {
        HandleShoot();
    }

    void HandleShoot()
    {
        if (!starterAssetsInputs.Shoot) return;

        muzzleFlash.Play();

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
            enemyHealth?.TakeDamage(damageAmount);
            //if (enemyHealth != null)
            //{
            //    enemyHealth.TakeDamage(damageAmount);
            //}
            starterAssetsInputs.ShootInput(false);
        }
    }
}
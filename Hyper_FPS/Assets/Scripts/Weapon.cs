using UnityEngine;
using StarterAssets;
public class Weapon : MonoBehaviour
{
    StarterAssetsInputs starterAssetsInputs;

    private void Awake()
    {
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
    }
    private void Update()
    {
        if(starterAssetsInputs.Shoot)
        {
            RaycastHit hit;

            if(Physics.Raycast(transform.position,Camera.main.transform.forward, out hit, Mathf.Infinity)){
                Debug.Log(hit.collider.name);
                starterAssetsInputs.Shoot = false;
            }
        }
    }
}


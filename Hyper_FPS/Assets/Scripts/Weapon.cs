using UnityEngine;

public class Weapon : MonoBehaviour
{
    private void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position,Camera.main.transform.forward, out hit, Mathf.Infinity)){
            Debug.Log(hit.collider.name);
        }
    }
}

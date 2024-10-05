using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class bullet_Behaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _force;
    private void Start(){
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _force = gameObject.transform.forward;
        StartCoroutine(Lifetime());
    }

    private void Update(){
        _rigidbody.Move(transform.position + _force, gameObject.transform.rotation);
    }

    private IEnumerator Lifetime(){
        yield return new WaitForSeconds(3f);
        DestroyBullet();
    }

    private void DestroyBullet(){
        Destroy(gameObject);
    }
}

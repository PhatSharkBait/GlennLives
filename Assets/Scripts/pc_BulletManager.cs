using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Scripting;

public class pc_Bullets : MonoBehaviour
{
    public GameObject bulletObj;
    private WaitForSeconds _waitForSeconds;
    private void Awake(){
        _waitForSeconds = new WaitForSeconds(.25f);
    }

    private void Start(){
        StartCoroutine(Timer());
    }
    private IEnumerator Timer(){
        yield return _waitForSeconds;
        Instantiate(bulletObj, gameObject.transform.position, gameObject.transform.rotation);
        StartCoroutine(Timer());
    }
}

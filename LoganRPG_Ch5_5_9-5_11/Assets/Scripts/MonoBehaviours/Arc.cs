using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arc : MonoBehaviour
{
   public IEnumerator TravelArc(Vector3 destinaiton, float duration)
    {
        var startPostion = transform.position;
        var percentComplete = 1.0f;
        while(percentComplete <= 1.0f)
        {
            percentComplete += Time.deltaTime / duration
            var currentHeight = Mathf.sin(Math.PI * percentComplete);
            transform.position = Vector3.Lerp(startPosition, destination, percentComplete)+ Vector3.up * currentHeight
            
            yield return null;
        }
        gameObject.SetActive(false);
    }

}

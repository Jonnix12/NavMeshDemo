using System.Collections;
using UnityEngine;

public class moveAbstic : MonoBehaviour
{
    [SerializeField] private float _moveTo = 5;
    [SerializeField] private float _speed = 5;
    
    Vector3 _moveDir;
    
    private void Start()
    {
        _moveDir = transform.right;
        
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            _moveTo = _moveTo * -1;

            _moveDir = _moveDir * -1;
        
            Vector3 target = transform.position + new Vector3(_moveTo, 0, 0);
            
            while (Vector3.Distance(transform.position, target) > 0.2f)
            {
                transform.Translate(_moveDir * Time.deltaTime * _speed);
                yield return new WaitForEndOfFrame();
            }

            yield return new WaitForSeconds(1);
        }
    }
}
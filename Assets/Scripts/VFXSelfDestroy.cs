using UnityEngine;

public class VFXSelfDestroy : MonoBehaviour
{
    private float _destroyTime;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _destroyTime += Time.deltaTime;
        if (_destroyTime > 0.8f)
        {
            Destroy(gameObject);
        }
    }
}

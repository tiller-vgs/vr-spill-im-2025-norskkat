using UnityEngine;

public class doorOpener : MonoBehaviour
{
    public GameObject obj1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(obj1);
    }
}

using UnityEngine;

public class characterScript : MonoBehaviour
{

    public GameObject BulletCloneTemplate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletCloneTemplate, transform.position,transform.rotation);
        }
        
  
    }
    
}

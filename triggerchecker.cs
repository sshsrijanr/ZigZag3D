using UnityEngine;

public class triggerchecker : MonoBehaviour {
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    public GameObject platform;
    void Start()
    {
        
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        
    }
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "ball"){
            Invoke("Falldown",0.5f);
        }
    }
    void Falldown(){
        platform.GetComponent<Rigidbody>().useGravity = true;
        Destroy(platform,2f);
    }
}
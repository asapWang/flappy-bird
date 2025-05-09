
using UnityEngine;


public class middleTriggerScript : MonoBehaviour
{
    public LogicManageScript logic;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManageScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==3)
        {
            logic.increaseScore(1);
        }
        
    }
}

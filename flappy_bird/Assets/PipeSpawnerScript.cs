using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float count = 2;
    public float height=8;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<count)
        {
            timer = timer+Time.deltaTime;
        }
        else
        {
            spawner();
            timer= 0;
        }
        
    }

    void spawner()
    {
        float lowestHeight=transform.position.y-height;
        float highestHeight=transform.position.y+height;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestHeight,highestHeight),transform.position.z),transform.rotation);
    }
}

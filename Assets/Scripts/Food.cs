using UnityEngine;

public class Food : MonoBehaviour
{
    public Collider2D foodArea;

    private void Start()
    {
        RandomPosition();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision);

        //Debug.Log(foodArea.bounds.min.x);
        //Debug.Log(foodArea.bounds.max.x);
        //Debug.Log(foodArea.bounds.min.y);
        //Debug.Log(foodArea.bounds.max.y);
        RandomPosition();
    }

    // 「讓食物隨機出現在指定區域內」的方法
    void RandomPosition()
    {
        transform.position = new Vector3(
            Random.Range(foodArea.bounds.min.x, foodArea.bounds.max.x),
            Random.Range(foodArea.bounds.min.y, foodArea.bounds.max.y),
            0);
    }
}

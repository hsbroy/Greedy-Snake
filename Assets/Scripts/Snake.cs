using UnityEngine;

public class Snake : MonoBehaviour
{
    Vector3 direction;
    public float speed = 0.1f;
    public Transform bodyPrefab; // 蛇身預製物

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(transform.position);

        Time.timeScale = speed; // 調整Unity的遊戲執行速度
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Debug.Log("W");
            // transform.Translate(0,1,0);
            direction = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Debug.Log("S");
            // transform.Translate(0, -1, 0);
            direction = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Debug.Log("A");
            // transform.Translate(-1, 0, 0);
            direction = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Debug.Log("D");
            // transform.Translate(1, 0, 0);
            direction = Vector3.right;
        }
        // transform.Translate(direction * Time.deltaTime); // 持續移動
    }

    private void FixedUpdate()
    {
        transform.Translate(direction); // 一格一格移動
    }
}

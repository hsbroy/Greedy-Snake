using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;


public class Snake : MonoBehaviour
{
    Vector3 direction;
    public float speed = 0.1f;

    public Transform bodyPrefab; // 蛇身預製物
    public List<Transform> bodies = new List<Transform>(); // 蛇身清單


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(transform.position);

        Time.timeScale = speed; // 調整Unity的遊戲執行速度

        // bodies.Add(transform); // 將蛇頭加入蛇身清單
        ResetStage(); // 初始化遊戲
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

    // 蛇移動行為的方法
    private void FixedUpdate() 
    {
        for(int i=bodies.Count-1; i>0; i--)
        {
            bodies[i].position = bodies[i - 1].position; // 蛇身跟隨前一節
        }

        transform.Translate(direction); // 一格一格移動
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            // Instantiate(bodyPrefab); // 產生蛇身
            bodies.Add(Instantiate(bodyPrefab, transform.position, Quaternion.identity)); // 在蛇頭位置產生蛇身並加入蛇身清單 \
            // Quaternion.identity 表示不旋轉
        }
        // Debug.Log(collision); // 碰撞偵測

        if (collision.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            ResetStage(); // 重置遊戲
        }
    }

    void ResetStage()
    {
        transform.position = Vector3.zero; // 重置位置
        direction = Vector3.zero; // 停止移動

        for (int i = 1; i < bodies.Count; i++)
        {
            Destroy(bodies[i].gameObject); // 刪除蛇身遊戲物件
        }
        bodies.Clear(); // 清空蛇身清單
        bodies.Add(transform); // 重新加入蛇頭
    }
}

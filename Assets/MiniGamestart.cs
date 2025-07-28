using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGamestart : MonoBehaviour
{
    // 플레이어가 트리거에 들어오면 즉시 씬 이동
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 미니게임 오브젝트에 닿음 → 씬 전환");
            SceneManager.LoadScene("MiniGameScene");
        }
    }
}

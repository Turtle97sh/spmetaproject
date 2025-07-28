using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private bool isPlayerNear = false;

    void Update()
    {
        // 플레이어가 상호작용 범위 내에 있고, E키를 눌렀을 때 씬 전환
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed, loading MiniGameScene...");
            // 씬을 단독으로 로드해서 기존 씬 닫기
            SceneManager.LoadScene("MiniGameScene", LoadSceneMode.Single);
        }
    }

    // 플레이어가 트리거 영역에 들어왔을 때
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            Debug.Log("Player entered trigger area.");
        }
    }

    // 플레이어가 트리거 영역에서 나갔을 때
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            Debug.Log("Player exited trigger area.");
        }
    }
}

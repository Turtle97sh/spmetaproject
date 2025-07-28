using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private bool isPlayerNear = false;

    void Update()
    {
        // �÷��̾ ��ȣ�ۿ� ���� ���� �ְ�, EŰ�� ������ �� �� ��ȯ
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E pressed, loading MiniGameScene...");
            // ���� �ܵ����� �ε��ؼ� ���� �� �ݱ�
            SceneManager.LoadScene("MiniGameScene", LoadSceneMode.Single);
        }
    }

    // �÷��̾ Ʈ���� ������ ������ ��
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            Debug.Log("Player entered trigger area.");
        }
    }

    // �÷��̾ Ʈ���� �������� ������ ��
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            Debug.Log("Player exited trigger area.");
        }
    }
}

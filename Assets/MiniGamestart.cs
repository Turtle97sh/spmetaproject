using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGamestart : MonoBehaviour
{
    // �÷��̾ Ʈ���ſ� ������ ��� �� �̵�
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ �̴ϰ��� ������Ʈ�� ���� �� �� ��ȯ");
            SceneManager.LoadScene("MiniGameScene");
        }
    }
}

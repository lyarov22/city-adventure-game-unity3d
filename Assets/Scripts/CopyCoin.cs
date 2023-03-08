using UnityEngine;

public class CopyCoin : MonoBehaviour
{
    public GameObject coinPrefab;   // ������ ������
    public float spawnInterval = 5f;   // �������� ������
    public int spawnCount = 50;   // ���������� �������

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        Vector3 spawnPosition = transform.position;   // ������� ������
        for (int i = 0; i < spawnCount; i++)
        {   
            GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);   // ������� ����� ������
            spawnPosition.z -= spawnInterval;   // ������� ������� ������ �� ��� Z �� 10 ������
            coin.transform.Rotate(90f, 0f, 90f);
        }
    }
}
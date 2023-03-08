using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // ����������, ������� ������ ���������� ��������� �����
    private int coins;

    private void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // ����������, ����� ��������� ��������� �������� ���������� ������
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // ���������� ������ ������
            Destroy(other.gameObject);

            // ���������� 1 � ���������� coins
            coins -= 1;
        }
    }

    void OnGUI()
    {
        Rect scoreRect = new Rect(10, 10, 100, 20);

        // ����������� ���������� ���� �� ������ � ������� ��������� ���������� "score"
        GUI.Label(scoreRect, "Score: " + coins);
    }
}
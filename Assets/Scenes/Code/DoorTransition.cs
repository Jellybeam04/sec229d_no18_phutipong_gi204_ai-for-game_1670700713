using UnityEngine;
using UnityEngine.SceneManagement; // จำเป็นต้องมีเพื่อเปลี่ยน Scene

public class DoorTransition : MonoBehaviour
{
    [Header("ชื่อ Scene ที่ต้องการไป")]
    public string sceneToLoad = "Menu"; // เปลี่ยนเป็นชื่อ Scene ถัดไปของคุณ

    private bool isPlayerNear = false; // เอาไว้เช็คว่าผู้เล่นอยู่ใกล้ประตูไหม

    void Update()
    {
        // ถ้าผู้เล่นอยู่ใกล้ประตู "และ" กดปุ่ม E บนคีย์บอร์ด
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // ฟังก์ชันนี้จะทำงานเมื่อมีคนเดินเข้ามาชนกล่อง Trigger
    private void OnTriggerEnter(Collider other)
    {
        // เช็คว่าคนที่เดินเข้ามา มี Tag ว่า "Player" หรือไม่
        if (other.CompareTag("Capsule"))
        {
            isPlayerNear = true;
            Debug.Log("กด E เพื่อเปลี่ยนฉาก"); // แสดงข้อความเช็คใน Console
        }
    }

    // ฟังก์ชันนี้จะทำงานเมื่อเดินออกจากกล่อง Trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Capsule"))
        {
            isPlayerNear = false;
        }
    }
}
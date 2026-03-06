using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTransition : MonoBehaviour
{
    [Header("ชื่อ Scene ที่ต้องการไป")]
    public string sceneToLoad = "Menu";

    // ฟังก์ชันนี้จะทำงานทันทีเมื่อมีคนเดินเข้ามาชนกล่อง Trigger ของประตู
    private void OnTriggerEnter(Collider other)
    {
        // เช็คว่าคนที่เดินเข้ามา มี Tag ว่า "Player" หรือไม่
        if (other.CompareTag("Player"))
        {
            Debug.Log("เดินชนประตูแล้ว! กำลังเปลี่ยนฉากไปที่: " + sceneToLoad);

            // สั่งโหลด Scene ใหม่ทันทีที่เดินชน
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
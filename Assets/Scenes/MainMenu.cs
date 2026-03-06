using UnityEngine;
using UnityEngine.SceneManagement; // สำคัญมาก ต้องมีบรรทัดนี้

public class MainMenu : MonoBehaviour
{
    // ฟังก์ชันนี้จะเอาไปผูกกับปุ่ม Start
    public void StartGame()
    {
        // เปลี่ยน "GameScene" เป็นชื่อ Scene เกมของคุณจริงๆ (ระวังตัวพิมพ์เล็ก-ใหญ่)
        SceneManager.LoadScene("SampleScene");
    }
}
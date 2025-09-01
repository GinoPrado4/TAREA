using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToTitle : MonoBehaviour
{
    public string titleSceneName = "SampleScene";
    public string playerMovementScriptName = "PlayerMovement";
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(titleSceneName);
    }

   
}
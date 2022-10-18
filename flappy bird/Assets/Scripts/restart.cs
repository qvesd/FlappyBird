using UnityEngine.SceneManagement;
using UnityEngine;

public class restart : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}

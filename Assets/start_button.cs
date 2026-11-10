using UnityEngine;
using UnityEngine.SceneManagement;

public class start_button : MonoBehaviour
{   
    public void loadnextscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    
    public void loadScene(Object sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad.name);
    }

    void Update()
    {
        
    }
}

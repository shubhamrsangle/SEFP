using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ApplicationManager : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Help()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}

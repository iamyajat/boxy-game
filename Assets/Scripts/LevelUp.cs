
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour {

    public void loadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

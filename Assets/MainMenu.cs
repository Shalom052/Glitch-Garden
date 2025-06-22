using UnityEngine;
using UnityEngine.SceneManagement; // Needed to load scenes
using UnityEngine.UI; // Needed if you want to reference UI components

namespace GlitchGarden
{
    public class MainMenu : MonoBehaviour
    {
        // This method is called when the Play button is clicked
        public void PlayGame()
        {
            // Replace "GameScene" with your actual game scene name
            SceneManager.LoadScene("GameScene");
        }

        // This method is called when the Settings button is clicked
        public void OpenSettings()
        {
            // Load a settings scene or open a settings menu here
            SceneManager.LoadScene("SettingsScene"); // Replace with your actual settings scene if any
        }

        // This method is called when the Quit button is clicked
        public void QuitGame()
        {
            Debug.Log("Quit Game"); // Shows message in Unity Editor
            Application.Quit();     // Quits the game (works only in build)
        }
    }
}


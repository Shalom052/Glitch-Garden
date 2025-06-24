using UnityEngine;
using UnityEngine.SceneManagement; // For scene loading
using UnityEngine.UI;              // For UI components

namespace GlitchGarden
{
    public class MainMenu : MonoBehaviour
    {
        // Called when "Play" or "New Game" button is clicked
        public void PlayGame()
        {
            // Load Level1 Scene
            SceneManager.LoadScene("Level1"); // Change "Level1" to match your scene name in Build Settings
        }

        // Called when "Settings" button is clicked
        public void OpenSettings()
        {
            // Load Settings Scene (if you have one)
            SceneManager.LoadScene("SettingsScene"); // Or remove this method if no SettingsScene exists
        }

        // Called when "Quit" button is clicked
        public void QuitGame()
        {
            Debug.Log("Quit Game"); // Works in Unity Editor for testing
            Application.Quit();     // Will quit the game in a built version
        }
    }
}

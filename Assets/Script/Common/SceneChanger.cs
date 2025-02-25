using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Common
{
    public class SceneChanger : MonoBehaviour
    {
        public void OnContinue()
        {
            SceneManager.LoadScene("GameScene");
        }

        public void OnMainMenu()
        {
            SceneManager.LoadScene("Start");
        }

        public void OnQuit()
        {
            Application.Quit();
        }
    }
}

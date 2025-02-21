using UnityEngine;
using UnityEngine.Rendering;

public class TrashJudgeManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static TrashJudgeManager Instance; //Singleton Instance
    public int count = 0;

    private void Awake()
    {
        //Ensure there is only one intance of GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //persist across scenes

        }
        else
        {
            Destroy(gameObject);
        }
    }
}

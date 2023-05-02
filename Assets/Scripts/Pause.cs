using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseTextObject;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseTextObject.SetActive(true);
        gameIsPaused = true;
    }
    public void ResumeGame()
    {
        pauseTextObject.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.lives = DisplayLives.Lives;
        save.score = DisplayPoints.Points;
        save.time = Timer.timer;
        save.playerName = DisplayName.playerName;

        return save;
    }

    public void SaveGame()
    {
        // 1
        Save save = CreateSaveGameObject();

        // 2
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Game Saved");
    }

    public void LoadGame()
    {
        // 1
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            // 2
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            // 4
            DisplayName.playerName = save.playerName;
            DisplayLives.Lives = save.lives;
            DisplayPoints.Points = save.score;
            Timer.timer = save.time;

            Debug.Log("Game Loaded");

            ResumeGame();
        }
        else
        {
            Debug.Log("No game saved!");
        }
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }

    public void NewGame()
    {
        DisplayLives.Lives = 1;
        DisplayPoints.Points = 0;
        Timer.timer = 30;
        Debug.Log("New Game");
        ResumeGame();
    }
}

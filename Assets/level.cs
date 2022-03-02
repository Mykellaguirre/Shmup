using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level : MonoBehaviour
{
    public static level instance;
    int score = 0;
    Text scoreText; 
    
    uint numEnemies = 0;
    bool startNextLevel = false;
    float nextLevelTimer = 3;

    string[] levels = { "Level1", "Level2" };
    int currentLevel = 1;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance ==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (startNextLevel)
        {
            if(nextLevelTimer <=0)
            {
                currentLevel++;
                if (currentLevel <= levels.Length)
                {
                    string sceneName = levels[currentLevel - 1];
                    SceneManager.LoadScene(sceneName);

                }
                else
                {
                    Debug.Log("GAME OVER!!");
                }
                nextLevelTimer = 3;
                startNextLevel = false;


            }
            else
            {
                nextLevelTimer -= Time.deltaTime;
            }
        }

    }

    public void AddScore(int amountToAdd)

    {
        score += amountToAdd;
        scoreText.text = score.ToString();
    }

    public void AddEnemy()
    {

        numEnemies++;
    }
    public void RemoveEnemy()
    {

    numEnemies--;
        if (numEnemies ==0)
        {
            startNextLevel = true;
        }
    }
 

        


}

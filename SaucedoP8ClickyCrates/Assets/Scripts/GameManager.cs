using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;



    private float spawnRate = 1.0f;

    public bool isGameActive;
    
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

            
        }
    }

        public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }


    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }



}    

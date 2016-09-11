using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{/*
    public static GameManager instance;

    public static PlayerController player{
        get { return instance._player; }
    }

    public GameObject powerupPrefab;
    public Text scoreText;
    public Text levelText;
    public Text livesText;
    public Text startText;
    public Text creditText;
    public Text ammoText;
    public Text finalScoreText;
    public Image HUD;
    public Image HUD02;


    public int level = 0;

    private int score = 0;
    private PlayerController _player;
    private PowerupController powerup;
    private KamakaziSpawner kamakaziSpawner;
    private AsteroidSpawner asteroidSpawner;
    private FighterSpawner fighterSpawner;
    private InventoryManager inv;
    private State gameState = State.Waiting;

    private List<GameObject> spawnedPowerups = new List<GameObject>();

    public enum State {
        Waiting,
        Playing,
        GameOver
    }

    void Awake() {
        if (instance == null){
            instance = this;

            //Debug.Log("SHOULD HAPPEN FIRST");
            _player = Object.FindObjectOfType(typeof(PlayerController)) as PlayerController;
            _player.gameObject.SetActive(false);

            asteroidSpawner = Object.FindObjectOfType(typeof(AsteroidSpawner)) as AsteroidSpawner;
            asteroidSpawner.gameObject.SetActive(false);

            kamakaziSpawner = Object.FindObjectOfType(typeof(KamakaziSpawner)) as KamakaziSpawner;
            kamakaziSpawner.gameObject.SetActive(false);

            fighterSpawner = Object.FindObjectOfType(typeof(FighterSpawner)) as FighterSpawner;
            fighterSpawner.gameObject.SetActive(false);

            inv = GetComponent<InventoryManager>();
        }
        else { 
            Destroy(gameObject);
        }
    }

    void Start() {
        SetScoreText();
    }

    void Update() {
        SetGameLevel();
        SetLevelText();
        SetLivesText();
        switch (gameState) {
            case State.Waiting:
                if (Input.anyKeyDown) {
                    gameState = State.Playing;
                    _player.gameObject.SetActive(true);
                    kamakaziSpawner.Reset();
                    fighterSpawner.Reset();
                    asteroidSpawner.Reset();
                    startText.gameObject.SetActive(false);
                    creditText.gameObject.SetActive(false);
                    finalScoreText.gameObject.SetActive(false);
                    levelText.gameObject.SetActive(true);
                    livesText.gameObject.SetActive(true);
                    scoreText.gameObject.SetActive(true);
                    ammoText.gameObject.SetActive(true);   
                    HUD.gameObject.SetActive(true); 
                    HUD02.gameObject.SetActive(true); 

                    score = 0;
                    level = 0;
                    player.gunIndex = 0;
                    ResetPlayerLives();
                    SetLivesText();
                    SetScoreText();
                    SetAmmoText();
                }
                break;

            case State.Playing:
                if (!_player.gameObject.activeSelf) {
                    gameState = State.GameOver;
                    _player.gameObject.SetActive(false);
                    kamakaziSpawner.gameObject.SetActive(false);
                    fighterSpawner.gameObject.SetActive(false);
                    asteroidSpawner.gameObject.SetActive(false);
                    startText.gameObject.SetActive(true);
                    creditText.gameObject.SetActive(true);
                    finalScoreText.gameObject.SetActive(true);
                    levelText.gameObject.SetActive(false);
                    livesText.gameObject.SetActive(false);
                    scoreText.gameObject.SetActive(false);
                    ammoText.gameObject.SetActive(false);  
                    HUD.gameObject.SetActive(false);
                    HUD02.gameObject.SetActive(false);  
                    startText.text = "Game Over";
                    SetFinalScoreText();
                }
                break;

            case State.GameOver:
                if (Input.anyKeyDown) {
                    gameState = State.Waiting;
                    startText.text = "Press Green Button to Start";
                }
                break;

            default:
                break;
        }
    }
    void SetScoreText() {
        scoreText.text = "Score: " + score;
    }

    void SetLevelText() {
        levelText.text = "Level: " + (level + 1);
    }

    void SetLivesText() {
        livesText.text = "Lives: " + player.currentLives;
    }

    void SetAmmoText() {
        InventoryManager.SetDefaultAmmoText();
    }
    void SetFinalScoreText() {
        finalScoreText.text = "Final Score: " + score;
    }
    void SetGameLevel() {
        if (kamakaziSpawner.allEnemiesSpawned && 
            fighterSpawner.allEnemiesSpawned && 
            asteroidSpawner.allEnemiesSpawned) {
            level += 1;
            kamakaziSpawner.totalSpawned = 0;
            fighterSpawner.totalSpawned = 0;
            asteroidSpawner.totalSpawned = 0;
            kamakaziSpawner.allEnemiesSpawned = false;
            fighterSpawner.allEnemiesSpawned = false;
            asteroidSpawner.allEnemiesSpawned = false;            
        }
    }

    void ResetPlayerLives() {
        player.currentLives = 3;
    }

    public void AddToScore(int pointValue) {
        instance.score += pointValue;
        instance.SetScoreText();
    }

    public static void SpawnPowerup(Vector3 spawnPosition) {
        int chance = Random.Range(1, 15);

        if (chance == 5 || chance == 10 || chance == 15) {
            GameObject powerup = instance.spawnedPowerups.Find(IsInactivePowerup);

            if (powerup == null) {
                powerup = Object.Instantiate(instance.powerupPrefab) as GameObject;
                instance.spawnedPowerups.Add(powerup);
            }
            else {
                powerup.SetActive(true);
            }

            powerup.transform.position = spawnPosition;
        }
    }

    static bool IsInactivePowerup(GameObject powerup) {
        return !powerup.activeSelf;
    }
    */
}
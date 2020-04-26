using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start() {
        BeginGame();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)){
            RestartGame();
        }
    }

    public Maze mazePrefab;

	private Maze mazeInstance;

    private void BeginGame(){
        mazeInstance = Instantiate(mazePrefab) as Maze;
        StartCoroutine(mazeInstance.Generate());
    }

    private void RestartGame(){
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}

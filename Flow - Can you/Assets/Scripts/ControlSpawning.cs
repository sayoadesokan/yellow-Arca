using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpawning : MonoBehaviour
{
    public spawnscript spawner1;
    public spawnscript spawner2;
    public spawnscript spawner3;
    public spawnscript spawner4;
    public GameManager GameManager;

    // Update is called once per frame
    void Update()
    {
        if(GameManager.score <= 30)
        {
            spawner1.spawnrate = 3;
            spawner2.spawnrate = 3;
            spawner3.spawnrate = 3;
            spawner4.spawnrate = 3;
        }
        else if (GameManager.score == 30)
        {
            spawner1.spawnrate = 3;
            spawner2.spawnrate = 3;
            spawner3.spawnrate = 3;
            spawner4.spawnrate = 3;
        }
        else if (GameManager.score >= 50)
        {
            spawner1.spawnrate = 3;
            spawner2.spawnrate = 3;
            spawner3.spawnrate = 3;
            spawner4.spawnrate = 3;
        }
    }
}

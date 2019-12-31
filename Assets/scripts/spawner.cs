using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{
    public GameObject boru;
    public float height;
    public float maxTime;
    float timer = 0;
    private void Start()
    {
        GameObject spawned = Instantiate(boru);
        spawned.transform.position += transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(spawned, 5);
    }
    private void Update()
    {
       if(maxTime<timer)
        {
            GameObject spawned = Instantiate(boru);
            spawned.transform.position += transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(spawned, 5);
            timer = 0;
        }
        timer += Time.deltaTime;

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

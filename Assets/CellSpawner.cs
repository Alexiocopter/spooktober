using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CellSpawner : MonoBehaviour
{
    public GameObject cell;
    private Vector3 spawnVector;
    public ParticleSystem particle;
    public float score = 0;
    public Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particle.transform.position = other.GetComponent<Transform>().position;
            SpawnCell();
            other.GetComponent<PlayerController>().rb.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            other.GetComponent<PlayerController>().speed *= 1.1f;

            score = score + 0.5f;
            ScoreUpdate();
        }
    }

    void SpawnCell()
    {
        float randX = Random.Range(-11, 17);
        float randZ = Random.Range(-25, -3);
        spawnVector = new Vector3(randX, -3.73f, randZ);



        cell.transform.position = spawnVector;

        particle.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreUpdate();
    }

    // Update is called once per frame
    void ScoreUpdate()
    {
        scoreText.text = "Score:" + score.ToString();
    }
}

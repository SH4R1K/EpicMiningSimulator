using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MineScripts : MonoBehaviour {

    private int Working;
    public GameObject WorkingPrefab;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("У");
        Working++;
        Destroy(other.gameObject);
    }

    public GameObject UIGame;
    public Text TextWork;

    private void Update()
    {
        if (Working <= 0)
        {
            UIGame.SetActive(false);
        }
        else if (Working >= 1)
        {
            UIGame.SetActive(true);
            TextWork.text = ("Рабочих: " + Working).ToString();

        }
    }

    public Transform gameObjectSpawnWorking;

    public void SpawnWorking()
    {
        Debug.Log("ewe");
        Instantiate(WorkingPrefab, gameObjectSpawnWorking);
        Working--;
    }
}

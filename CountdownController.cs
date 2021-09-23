using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    GameObject gm;
    Text countdownText;

    void Start()
    {
        if (gm == null){
            gm = GameObject.FindGameObjectWithTag("GameController");
        }
        countdownText = GetComponent<Text>();
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart() {
        while(countdownTime > 0){
            countdownText.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        gm.GetComponent<GameManager>().BeginGame();
        this.gameObject.SetActive(false);
    }
}

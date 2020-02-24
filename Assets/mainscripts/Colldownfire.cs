using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Colldownfire : MonoBehaviour {   
    public GameObject fill;

    public Image colldowns;

    public float colldownTime = 2.5f;
    
    public float colldownFrequence = 0.3f;

    public IEnumerator StartCountdown(float secondsForWait, float dividerValue) {
        float startTimeBuffer = secondsForWait;
        while (secondsForWait > 0) {
            yield return new WaitForSeconds(dividerValue);
            updateAmount(secondsForWait / startTimeBuffer);
            secondsForWait -= dividerValue;
        }
        gameObject.SetActive(false);
    }

    private void updateAmount(float percents) {
        colldowns.fillAmount = percents;
    }

    public void StartCountdownTimer() {
        StartCoroutine(StartCountdown(colldownTime, colldownFrequence));
    }
}

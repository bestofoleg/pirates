using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Colldownfire : MonoBehaviour {   
    public Image colldownImage;

    public float colldownTime = 2.5f;
    
    public float colldownFrequence = 0.3f;

    public IEnumerator StartCountdown(float secondsForWait, float dividerValue) {
        float startTimeBuffer = secondsForWait;
        while (secondsForWait > 0) {
            yield return new WaitForSeconds(dividerValue);
            updateAmount(secondsForWait / startTimeBuffer);
            secondsForWait -= dividerValue;
        }
        colldownImage.gameObject.SetActive(false);
    }

    private void updateAmount(float percents) {
        colldownImage.fillAmount = percents;
    }

    public void StartCountdownTimer() {
        StartCoroutine(StartCountdown(colldownTime, colldownFrequence));
    }
}

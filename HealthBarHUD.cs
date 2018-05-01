using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHUD : MonoBehaviour {

    public Image full;
    public Image mid;
    public PlayerHealthSystem phs;

    public float midPercent = 0.5f;
    public float dangerPercent = 0.15f;
    public float lowPercent = 0.3f;

    // Use this for initialization
    void Start () {
        if((phs.health/phs.max_health) < this.midPercent)
        {
            full.fillAmount = 0;
            mid.fillAmount = (2*phs.health ) / phs.max_health;
        }
        else
        {
            mid.fillAmount = 1;
            full.fillAmount = (phs.health / phs.max_health);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        if ((phs.health / phs.max_health) < this.midPercent)
        {
            mid.fillAmount = (2*phs.health) / phs.max_health;
            full.fillAmount = 0;
        }
        else
        {
            mid.fillAmount = 1;
            full.fillAmount = (phs.health / phs.max_health);
        }
    }
}

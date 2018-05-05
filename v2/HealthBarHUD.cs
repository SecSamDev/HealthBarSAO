using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHUD : MonoBehaviour {

    public Sprite normal;
    public Sprite low;
    public Sprite danger;
    public Image HP;
    public PlayerHealthSystem phs;

    public float midPercent = 0.5f;
    public float dangerHP = 0.15f;
    public float lowHP = 0.4f;
    public RectTransform hpRect;
    // Use this for initialization
    void Start () {
        hpRect = this.HP.gameObject.GetComponent<RectTransform>();

        if (hpRect != null )
        {
            hpRect.localPosition = new Vector3(((2*phs.health) / phs.max_health) * (this.hpRect.rect.width / 2) + (-this.hpRect.rect.width), hpRect.localPosition.y, hpRect.localPosition.z);
            
        }
        
        
	}
	
	// Update is called once per frame
	void Update () {
        if (hpRect != null)
        {
            hpRect.localPosition = new Vector3(((2*phs.health) / phs.max_health) * (this.hpRect.rect.width / 2) + (-this.hpRect.rect.width), hpRect.localPosition.y, hpRect.localPosition.z);
            if ((phs.health / phs.max_health) < this.dangerHP)
            {
                this.HP.sprite = danger;
            }
            else if ((phs.health / phs.max_health) < this.lowHP)
            {
                this.HP.sprite = low;
            }
            else
            {
                this.HP.sprite = normal;
            }
            if(phs.health > phs.max_health)
            {
                hpRect.localPosition = new Vector3(0, hpRect.localPosition.y, hpRect.localPosition.z);
            }else if(phs.health < 0)
            {
                hpRect.localPosition = new Vector3(-this.hpRect.rect.width, hpRect.localPosition.y, hpRect.localPosition.z);
            }
        }
    }
}

# SAO HP Bar

A SAO health bar for unity3D

![HealthBar finished](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/healthBarFinish.gif)


Design inspired by: [darkblackswords](https://darkblackswords.deviantart.com/art/Sword-Art-Online-HP-Bar-342436869)

### Install SVG converter
First we need to install SVG to PNG convertes like [convert-svg-to-png](https://github.com/NotNinja/convert-svg) nodejs library:

```
npm install --save convert-svg-to-png
```

Convert SVG to PNG
```
convert-svg-to-png .\hud_bar.svg
convert-svg-to-png .\hud_full.svg
convert-svg-to-png .\hud_mid.svg
convert-svg-to-png .\hud_wrapper.svg
```
Result:

Background:

![HealthBarSAO](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/hud_background.png)

Normal HP:

![HealthBarSAO](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/hud_hp_normal.png)

Low HP:

![HealthBarSAO](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/hud_hp_low.png)

Danger HP:

![HealthBarSAO](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/hud_hp_danger.png)

Mask:

![HealthBarSAO](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/hud_mask.png)

Wrapper:

![HealthBarSAO](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/hud_wrapper.png)

### Preparing sprites

Prepare the pngs as Unity Sprites:

![Texture Preparation](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v1/TextureType.PNG)

### Prepare GameObjects

![GameObjects](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/GameObjects.PNG)

### Prepare Components

![Components HealthBar](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/HealthBarComponents.PNG)

![Components Mask](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/MaskComponents.PNG)

### Script time

```
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
```

This will move the image from positionX 0 (full HP) to -width(0 HP).

### HOW IT WORKS

![HealthBar finished](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/NoMaskV2.gif)

### Final Result

![HealthBar finished](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/healthBarFinish.gif)

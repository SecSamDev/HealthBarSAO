# HealthBarSAO
A SAO health bar for unity3D

![HealthBar finished](HealthBarFinish.gif)

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
![HealthBarSAO](hud_bar.png)

### Preparing sprites

Prepare the pngs as Unity Sprites:
![Texture Preparation](TextureType.png)

![SpritesInDirectory](files.png)

Set up the game objects as:
![Game Objects](HUDinUnity.png)
![Scene](HealthBarScene.png)

Now you need to prepare the midBar and FullBar:
ImageType: Filled
Fill Method horizontal.
Fill Origin Left.
Fill Amount 1 (this value is used to cut the image)
![MidBar](MidBarImage.png)

### Script Time
The next code allow us to set the full bar "not visible" when the health of the player is less than 50% and if its more than 50% then midbar fill amount is always 1 (always visible).
```
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
```

### Wraping all together

Assign the components to the HealthBar GameObject:
![HealthBarComponent](HealthBarComponents.png)


## Final Result

![HealthBar finished](HealthBarFinish.gif)
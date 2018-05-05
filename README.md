# HealthBarSAO
A SAO health bar for unity3D

Design inspired by: [darkblackswords](https://darkblackswords.deviantart.com/art/Sword-Art-Online-HP-Bar-342436869)

## V1

![HealthBar finished](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v1/healthBarFinish.gif)

## V2

![HealthBar finished](https://raw.githubusercontent.com/SecSamDev/HealthBarSAO/master/v2/healthBarFinish.gif)

### Install SVG converter
Its necesary to install first NodeJS and NPM: [NodeJS](https://nodejs.org/es/)
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


# CPSC 481 Low Fedelity
Repository for the compiling and creating of project deliverable three.  
## Materialize
[Google Material Design Guidlines](https://material.io/guidelines/)  
[Roboto Font](https://fonts.google.com/specimen/Roboto)  
The Google Material design is a common standard that you'll recognize from many other websites. The standard outlines many components that we will use such as drop downs and cards. Please take a look at the components and the patterns. I am hoping that we can install a component library that implements the Materials design, but have yet to do so.  
## Colors
[Common colors and their hex values](https://vuetifyjs.com/en/style/colors)  
![Color wheel](https://cdn-images-1.medium.com/max/2000/1*6BgDDX9LZ5OkoPEe79VfMA.png "Color wheel")    
[Theme Generator (to see how the colors are used together)](https://vuetifyjs.com/en/theme-generator)  
We are doing a triad color pallate, it would be very handy to have some sort of enum that we could quickly prototype with. It would require we pass in some sort of theme object when a component is initialized and manually set the color in the code versus the designer. One of our features was the ability to change themes in the settings so I think it would be better to prepare for this right now. By all means we can change this, however I think we should stick with a red, orange, green warning system.
``` javascript
{ 
    primary: "#00BCD4",     //CYAN
    secondary: "#EF5350",   //RED
    accent: "#006064",      //DARK CYAN
    error: "#f44336",       //RED
    warning: "#FFC107",     //ORANGE
    info: "#2196f3",        //LIGHT BLUE
    success: "#4caf50"      //GREEN
}
```

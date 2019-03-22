import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";
import UserTexts from "./UserTexts";
import ImageSelector from "./ImageSelector";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: "./Images/4.jpg",
      topText: "TOP TEXT",
      bottomText: "BOTTOM TEXT",
      images: [
        "./Images/Kid.jpg",
        "./Images/StarTrek.jpg",
        "./Images/Taken.jpg",
        "./Images/0.jpg",
        "./Images/1.jpg",
        "./Images/2.jpg",
        "./Images/3.jpg",
        "./Images/4.jpg",
        "./Images/5.jpg",
        "./Images/6.jpg",
        "./Images/7.jpg",
        "./Images/8.jpg",
        "./Images/9.jpg",
        "./Images/10.jpg",
        "./Images/11.jpg",
        "./Images/12.jpg",
        "./Images/13.jpg",
        "./Images/14.jpg",
        "./Images/15.jpg",
        "./Images/16.jpg"
      ]
    };
  }

  setTopText = text => {
    this.setState({ topText: text });
  };

  setBottomText = text => {
    this.setState({ bottomText: text });
  };

  setImage = path => {
    this.setState({ previewImage: path });
  };

  render() {
    return (
      <div className="app">
        <Preview
          image={this.state.previewImage}
          top={this.state.topText}
          bottom={this.state.bottomText}
        />
        <UserTexts
          top={this.state.topText}
          setTop={this.setTopText}
          bottom={this.state.bottomText}
          setBottom={this.setBottomText}
        />
        <ImageSelector images={this.state.images} setImage={this.setImage} />
      </div>
    );
  }
}

export default App;

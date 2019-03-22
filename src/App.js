import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";
import UserTexts from "./UserTexts";
import ImageSelector from "./ImageSelector";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: "./Images/Kid.jpg",
      topText: "TOP TEXT",
      bottomText: "BOTTOM TEXT",
      images: [
        "./Images/Kid.jpg",
        "./Images/StarTrek.png",
        "./Images/Taken.jpg"
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

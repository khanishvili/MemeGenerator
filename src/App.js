import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";
import UserTexts from "./UserTexts";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: "./Images/Kid.jpg",
      topText: "Top TEXT",
      bottomText: "Bottom TEXT"
    };
  }

  setTopText = text => {
    this.setState({ topText: text });
  };

  setBottomText = text => {
    this.setState({ bottomText: text });
  };

  render() {
    return (
      <div>
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
      </div>
    );
  }
}

export default App;

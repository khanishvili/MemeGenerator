import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: "./Images/Kid.jpg",
      topText: "Top TEXT",
      bottomText: "Bottom TEXT"
    };
  }
  render() {
    return (
      <div>
        <Preview
          image={this.state.previewImage}
          top={this.state.topText}
          bottom={this.state.bottomText}
        />
      </div>
    );
  }
}

export default App;

import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: "./Images/Kid.jpg"
    };
  }
  render() {
    return (
      <div>
        <Preview image={this.state.previewImage} />
      </div>
    );
  }
}

export default App;

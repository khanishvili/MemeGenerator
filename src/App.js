import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";
import Pic0 from "./Images/Kid.jpg";
import Pic1 from "./Images/StarTrek.png";
import Pic2 from "./Images/Taken.jpg";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: Pic0
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

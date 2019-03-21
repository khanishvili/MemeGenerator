import React, { Component } from "react";

export default class Preview extends Component {
  render() {
    const { image, top, bottom } = this.props;
    return (
      <div>
        <h1>{top}</h1>
        <img
          src={image}
          alt="Selected Meme Template"
          style={{ maxWidth: "70vw", maxHeight: "70vh" }}
        />
        <h1>{bottom}</h1>
      </div>
    );
  }
}

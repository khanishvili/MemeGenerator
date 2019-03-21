import React, { Component } from "react";

export default class Preview extends Component {
  render() {
    const { image } = this.props;
    return (
      <div>
        <h1>Top Text</h1>
        <img src={image} style={{ maxWidth: "70vw", maxHeight: "70vh" }} />
        <h1>Bottom Text</h1>
      </div>
    );
  }
}

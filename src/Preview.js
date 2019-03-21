import React, { Component } from "react";

export default class Preview extends Component {
  render() {
    const { image, top, bottom } = this.props;
    return (
      <div className="preview">
        <h1 className="top-text">{top}</h1>
        <img src={image} alt="Selected Meme Template" />
        <h1 className="bottom-text">{bottom}</h1>
      </div>
    );
  }
}

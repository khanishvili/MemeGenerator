import React, { Component } from "react";
import "./Preview.css";

export default class Preview extends Component {
  render() {
    const { image, top, bottom } = this.props;
    return (
      <div
        className="preview"
        id="preview"
        style={{
          backgroundImage: `url(${image})`,
          backgroundSize: "cover",
          backgroundRepeat: "no-repeat",
          backgroundPosition: "center"
        }}
      >
        <h1 className="top-text">{top}</h1>
        <h1 className="bottom-text">{bottom}</h1>
      </div>
    );
  }
}

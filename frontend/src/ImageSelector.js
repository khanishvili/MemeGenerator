import React, { Component } from "react";
import "./ImageSelector.css";

export default class ImageSelector extends Component {
  onImageClick = event => {
    this.props.setImage(event.target.src);
  };

  render() {
    const { images } = this.props;
    const imageList = images.map(image => (
      <li key={image}>
        <img src={image} alt="Selector" onClick={this.onImageClick} />
      </li>
    ));

    return (
      <ul className="image-selector">
        <h1>Image Selector</h1>
        {imageList}
      </ul>
    );
  }
}

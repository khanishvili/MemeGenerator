import React, { Component } from "react";

export default class ImageSelector extends Component {
  onImageClick = event => {
    this.props.setImage(event.target.src);
  };
  render() {
    const { images } = this.props;
    const imageList = images.map(image => (
      <li key={image}>
        <img src={image} onClick={this.onImageClick} />
      </li>
    ));
    return <ul>{imageList}</ul>;
  }
}
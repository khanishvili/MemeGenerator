import React, { Component } from "react";
import domtoimage from "dom-to-image-more";

export default class UserTexts extends Component {
  topChange = event => {
    this.props.setTop(event.target.value);
  };

  bottomChange = event => {
    this.props.setBottom(event.target.value);
  };

  render() {
    const { top, bottom } = this.props;
    const makePic = () => {
      const node = document.getElementById("preview");
      domtoimage
        .toPng(node)
        .then(function(dataUrl) {
          let img = new Image();
          img.src = dataUrl;
          const imgsel = document.querySelector(".image-selector");
          imgsel.appendChild(img);
        })
        .catch(function(error) {
          console.error("oops, something went wrong!", error);
        });
    };

    return (
      <div className="user-texts">
        <div>
          <label>Top Text:</label>
          <input type="text" value={top} onChange={this.topChange} />
        </div>
        <div>
          <label>Bottom Text:</label>
          <input type="text" value={bottom} onChange={this.bottomChange} />
        </div>
        <button type="Submit" onClick={makePic} />
      </div>
    );
  }
}

import React, { Component } from "react";
import "./UserTexts.css";
import domtoimage from "dom-to-image-more";

export default class UserTexts extends Component {
  topChange = event => {
    this.props.setTop(event.target.value);
  };

  bottomChange = event => {
    this.props.setBottom(event.target.value);
  };

  addToShowcase = () => {
    const newMeme = {
      top: this.props.top,
      bottom: this.props.bottom,
      image: this.props.image
    };
    this.props.addNew(newMeme);
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
          var modal = document.getElementById("myModal");
          modal.style.display = "block";
          const modalContent = document.querySelector(".modal-content");
          var span = document.querySelector(".close");
          span.onclick = function() {
            modal.style.display = "none";
            modalContent.removeChild(modalContent.childNodes[1]);
          };
          window.onclick = function(event) {
            if (event.target === modal) {
              modal.style.display = "none"; // Get the <ul> element with id="myList"
              modalContent.removeChild(modalContent.childNodes[1]);
            }
          };

          modalContent.appendChild(img);
        })
        .catch(function(error) {
          console.error("oops, something went wrong!", error);
        });
    };

    return (
      <div className="user-texts">
        <div className="text-input">
          <label>Top Text:</label>
          <input type="text" value={top} onChange={this.topChange} />
          <button onClick={this.addToShowcase}>Add to Showcase</button>
        </div>
        <div className="text-input">
          <label>Bottom Text:</label>
          <input type="text" value={bottom} onChange={this.bottomChange} />
          <button onClick={makePic}>Create Png</button>
        </div>
        <div id="myModal" className="modal">
          <div className="modal-content">
            <span className="close">&times;</span>
          </div>
        </div>
      </div>
    );
  }
}

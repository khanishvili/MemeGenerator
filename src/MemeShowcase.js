import React, { Component } from "react";
import "./MemeShowcase.css";

export default class MemeShowcase extends Component {
  onImageClick = event => {
    this.props.setImage(event.target.src);
  };

  render() {
    const { memes } = this.props;
    const memeList = memes.map(meme => (
      <li
        key={meme.id}
        className="memes"
        style={{
          backgroundImage: `url(${meme.image})`,
          backgroundSize: "cover",
          backgroundRepeat: "no-repeat",
          backgroundPosition: "center",
          height: "40%"
        }}
      >
        <h1 className="top-text">{meme.top}</h1>
        <h1 className="bottom-text">{meme.bottom}</h1>
      </li>
    ));

    return <ul className="meme-showcase">{memeList}</ul>;
  }
}

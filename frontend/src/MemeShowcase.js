import React, { Component } from "react";
import "./MemeShowcase.css";

export default class MemeShowcase extends Component {
  onMemeClick = (image, top, bottom) => {
    this.props.setImage(image);
    this.props.setTop(top);
    this.props.setBottom(bottom);
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
        onClick={this.onMemeClick.bind(this, meme.image, meme.top, meme.bottom)}
      >
        <h1 className="top-text">{meme.top}</h1>
        <h1 className="bottom-text">{meme.bottom}</h1>
      </li>
    ));

    return <ul className="meme-showcase">{memeList}</ul>;
  }
}

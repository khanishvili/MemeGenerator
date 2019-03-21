import React, { Component } from "react";

export default class UserTexts extends Component {
  topChange = event => {
    this.props.setTop(event.target.value);
  };

  bottomChange = event => {
    this.props.setBottom(event.target.value);
  };

  render() {
    const { top, bottom } = this.props;
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
      </div>
    );
  }
}

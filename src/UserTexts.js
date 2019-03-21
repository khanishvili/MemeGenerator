import React, { Component } from "react";

export default class UserTexts extends Component {
  render() {
    const { top, bottom } = this.props;
    return (
      <div>
        <input type="text" value={top} />
        <input type="text" value={bottom} />
      </div>
    );
  }
}

import React, { Component } from "react";
import "./App.css";
import Preview from "./Preview";
import UserTexts from "./UserTexts";
import ImageSelector from "./ImageSelector";
import MemeShowcase from "./MemeShowcase";

class App extends Component {
  constructor() {
    super();
    this.state = {
      previewImage: "./Images/4.jpg",
      topText: "Js on my tree",
      bottomText: "Yo git like me",
      images: [
        "./Images/Kid.jpg",
        "./Images/StarTrek.png",
        "./Images/Taken.jpg",
        "./Images/0.jpg",
        "./Images/1.jpg",
        "./Images/2.jpg",
        "./Images/3.jpg",
        "./Images/4.jpg",
        "./Images/5.jpg",
        "./Images/6.jpg",
        "./Images/7.jpg",
        "./Images/8.jpg",
        "./Images/9.jpg",
        "./Images/10.jpg",
        "./Images/11.jpg",
        "./Images/12.jpg",
        "./Images/13.jpg",
        "./Images/14.jpg",
        "./Images/15.jpg",
        "./Images/16.jpg"
      ],
      memes: [
        {
          id: "1",
          top: "this is the top",
          bottom: "this is the bottom",
          image: "./Images/0.jpg"
        },
        {
          id: "2",
          top: "this is the top",
          bottom: "this is the bottom",
          image: "./Images/1.jpg"
        }
      ]
    };
  }

  componentDidMount() {
    fetch("https://localhost:44337/api/memes")
      .then(res => res.json())
      .then(json => this.setState({ memes: json }));
  }

  addNew = userMeme => {
    fetch("https://localhost:44337/api/memes", {
      method: "POST",
      headers: {
        "Content-type": "application/json"
      },
      body: JSON.stringify(userMeme)
    })
      .then(res => {
        if (res.ok) {
          const newMemes = [...this.state.memes, userMeme];
          this.setState({ memes: newMemes });
        }
      })
      .catch(err => {
        console.error(err);
      });
  };

  setTopText = text => {
    this.setState({ topText: text });
  };

  setBottomText = text => {
    this.setState({ bottomText: text });
  };

  setImage = path => {
    this.setState({ previewImage: path });
  };

  render() {
    return (
      <div className="app">
        <Preview
          image={this.state.previewImage}
          top={this.state.topText}
          bottom={this.state.bottomText}
        />
        <UserTexts
          top={this.state.topText}
          setTop={this.setTopText}
          bottom={this.state.bottomText}
          setBottom={this.setBottomText}
          image={this.state.previewImage}
          addNew={this.addNew}
        />
        <ImageSelector images={this.state.images} setImage={this.setImage} />
        <MemeShowcase
          memes={this.state.memes}
          setImage={this.setImage}
          setTop={this.setTopText}
          setBottom={this.setBottomText}
        />
      </div>
    );
  }
}

export default App;

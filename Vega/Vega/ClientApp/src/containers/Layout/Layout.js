import React, { Component, Fragment } from 'react';

import NavBar from '../../components/NavBar/NavBar';
import Footer from '../../components/Footer/Footer';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <Fragment>
        <NavBar/>
        {this.props.children}
        <Footer/>
      </Fragment>
    );
  }
}

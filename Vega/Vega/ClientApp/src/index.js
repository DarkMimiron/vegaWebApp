import 'bootstrap/dist/css/bootstrap.css';
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import { MuiThemeProvider, createMuiTheme } from "@material-ui/core/styles";
import { blue, purple } from "@material-ui/core/colors";
import CssBaseline from '@material-ui/core/CssBaseline';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const theme = createMuiTheme({
    palette: {
        primary: {
            main: blue.A200
        },
        secondary: {
            main: purple.A400
        }
    },
    typography: { 
        useNextVariants: true 
    },
});
const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
  <BrowserRouter basename={baseUrl}>
      <MuiThemeProvider theme={theme}>
          <CssBaseline/>
          <App />
      </MuiThemeProvider>
  </BrowserRouter>,
  rootElement);

registerServiceWorker();

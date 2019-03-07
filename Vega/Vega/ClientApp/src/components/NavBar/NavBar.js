import React from 'react';
import { AppBar, Toolbar, Typography} from "@material-ui/core";
import { withStyles } from "@material-ui/core/styles";

import NavItems from './NavItems/NavItems';

const styles = {
    root: {
        flexGrow: 1
    },
    grow: {
        flexGrow: 1
    }
};

const navBar = (props) => (
  <div>
      <AppBar position="static" className={props.classes.root}>
          <Toolbar>
              <Typography variant="h6" className={props.classes.grow}>
                  Vega
              </Typography>
              <NavItems />
          </Toolbar>
      </AppBar>
  </div>  
);

export default withStyles(styles)(navBar);
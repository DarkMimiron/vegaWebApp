import React from 'react';
import {AppBar, Toolbar, Typography} from "@material-ui/core";
import { withStyles } from "@material-ui/core/styles";

const styles = {
    root: {
        flexGrow: 1
    },
    grow: {
        flexGrow: 1
    }
};

const footer = (props) => (
    <div>
        <AppBar position="static" className={props.classes.root}>
            <Toolbar>
                <Typography variant="h6" className={props.classes.grow}>
                    Hello from footer
                </Typography>
            </Toolbar>
        </AppBar>
    </div>
);

export default withStyles(styles)(footer);
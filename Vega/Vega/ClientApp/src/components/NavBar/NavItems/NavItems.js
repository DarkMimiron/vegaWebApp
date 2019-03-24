import React from 'react';
import {Button, Typography} from "@material-ui/core";
import {Add} from "@material-ui/icons/";
import {Link} from "react-router-dom";

const navItems = () => (
    <div>
        <Button component={Link} to="/">Home</Button>
        <Button component={Link} to="/counter">Counter</Button>
        <Button component={Link} to="/fetch-data">Fetch</Button>
        <Button variant="contained" color="secondary" component={Link} to="/vehicles">
            <Add/><Typography color="textSecondary" variant="button"> New Vehicle</Typography>
        </Button>
    </div>
);

export default navItems;
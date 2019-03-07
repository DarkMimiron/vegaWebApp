import React from 'react';
import {Button} from "@material-ui/core";
import {Link} from "react-router-dom";

const navItems = () => (
    <div>
        <Button component={Link} to="/">Home</Button>
        <Button component={Link} to="/counter">Counter</Button>
        <Button component={Link} to="/fetch-data">Fetch</Button>
        <Button component={Link} to="/vehicles">Vehicles</Button>
    </div>
);

export default navItems;
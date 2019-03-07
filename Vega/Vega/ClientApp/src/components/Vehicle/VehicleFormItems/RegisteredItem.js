import React from 'react';
import {FormControl, FormLabel, RadioGroup, FormControlLabel, Radio} from "@material-ui/core";
import { withStyles } from "@material-ui/core/styles";

const registeredItem = (props) => (
    <FormControl component="fieldset">
        <FormLabel component="legend">Is this vehicle registered?</FormLabel>
        <RadioGroup
            aria-label="Registered"
            name="registered"
            value={props.isRegistered}
            onChange={props.changeRegister}
        >
            <FormControlLabel value="yes" control={<Radio />} label="Yes" />
            <FormControlLabel value="no" control={<Radio />} label="No" />
        </RadioGroup>
    </FormControl>
);

export default registeredItem;
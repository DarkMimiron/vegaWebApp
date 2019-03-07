import React from 'react';
import {FormControl, Input, InputLabel, MenuItem, Select} from "@material-ui/core";
import { withStyles } from "@material-ui/core/styles";

const styles = theme => ({
    formControl: {
        margin: theme.spacing.unit,
        minWidth: 120,
    },
    selectEmpty: {
        marginTop: theme.spacing.unit * 2,
    }  
});

const brandsItem = props => (
    <FormControl className={props.classes.formControl}>
        <InputLabel htmlFor="brandSelect">Brand</InputLabel>
        <Select
            value={props.valueSelected}
            onChange={props.changeBrand}
            input={<Input name="brand" id="brandSelect"/>}
            displayEmpty
            autoWidth
            className={props.classes.selectEmpty}
        >
            <MenuItem value={0}>
                <em>None</em>
            </MenuItem>
            {props.brandsList}
        </Select>
    </FormControl>
);

export default withStyles(styles)(brandsItem);
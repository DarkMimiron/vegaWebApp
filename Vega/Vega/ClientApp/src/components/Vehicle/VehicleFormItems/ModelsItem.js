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

const modelsItem = props => (
    <FormControl className={props.classes.formControl} disabled={!props.isActive}>
        <InputLabel htmlFor="modelSelect">Model</InputLabel>
        <Select
            value={props.valueSelected}
            input={<Input name="model" id="modelSelect"/>}
            onChange={props.changeModel}
            displayEmpty
            autoWidth
            className={props.classes.selectEmpty}
        >
            <MenuItem value={0}>
                <em>None</em>
            </MenuItem>
            {props.modelsList}
        </Select>
    </FormControl>
);

export default withStyles(styles)(modelsItem);
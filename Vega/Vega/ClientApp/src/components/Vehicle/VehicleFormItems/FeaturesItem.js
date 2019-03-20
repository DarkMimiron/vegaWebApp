import React from 'react';
import {FormControl, FormLabel, FormGroup, Grid} from "@material-ui/core";

const featuresItem = props => (
    <FormControl>
        <FormLabel component="legend">Features</FormLabel>
        <FormGroup>
            <Grid container>
                {props.featuresList}
            </Grid>
        </FormGroup>
    </FormControl>
);

export default featuresItem;
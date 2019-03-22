import React from 'react';
import {TextField, Grid} from "@material-ui/core";

const contactItems = props => (
    <Grid container spacing={24}>
        <Grid item xs={12}>
            <TextField
                id={"contactName"}
                label={"Contact Name"}
                placeholder={"Contact Name"}
                fullWidth
                margin={"normal"}
            />
        </Grid>
        <Grid item xs={6}>
            <TextField
                id={"contactPhone"}
                label={"Contact Phone"}
                placeholder={"Contact Phone"}
                fullWidth
                margin={"normal"}
                type="number"
            />
        </Grid>
        <Grid item xs={6}>
            <TextField
                id={"contactEmail"}
                label={"Contact Email"}
                placeholder={"Contact Email"}
                fullWidth
                margin={"normal"}
                type="email"
            />
        </Grid>
    </Grid>
    
);

export default contactItems;
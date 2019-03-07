import React, { Component} from 'react';
import {Grid, Paper} from "@material-ui/core";

import VehicleForm from '../../components/Vehicle/VehicleForm';

class VehiclePage extends Component{
    static displayName = VehiclePage.name;
    
    styles = {
        Paper: {
            padding: 20,
            marginTop: 10,
            marginBottom: 10,
        }
    };
    
    render() {
        return (
          <Grid container spacing={16}>
              <Grid item xs={12}>
                  <Paper style={this.styles.Paper}>
                      <VehicleForm/>
                  </Paper>
              </Grid>
          </Grid>  
        );
    }
}

export default VehiclePage;
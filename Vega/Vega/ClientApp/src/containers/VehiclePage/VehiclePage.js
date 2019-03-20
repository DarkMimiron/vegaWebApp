import React, { Component} from 'react';
import {Paper} from "@material-ui/core";

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
            <Paper style={this.styles.Paper}>
                <VehicleForm/>
            </Paper>
        );
    }
}

export default VehiclePage;
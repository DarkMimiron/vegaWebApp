import React, {Component} from 'react';
import {Grid, MenuItem} from "@material-ui/core";
import axios from "axios";

import BrandsItem from './VehicleFormItems/BrandsItem';
import ModelsItem from './VehicleFormItems/ModelsItem';
import RegisteredItem from './VehicleFormItems/RegisteredItem';

class VehicleForm extends Component {
    static displayName = VehicleForm.name;

    styles = {
        root: {
            display: 'flex',
            flexWrap: 'wrap',
        }
    };
    
    state = {
        brands: [],
        selectedBrandId: 0,
        models: [],
        selectedModelId: 0,
        withBrand: false,
        isRegistered: "no"
    };

    componentDidMount() {
        axios.get("/api/brands")
            .then(response => {
                this.setState({brands: response.data});
            });
    }

    handleBrandChange = event => {
        let models = null;
        let withBrand = false;
        
        if (event.target.value !== 0) {
            models = this.state.brands[event.target.value - 1].models;
            withBrand = true;
        }

        this.setState({ 
            selectedBrandId: event.target.value,
            models: models,
            selectedModelId: 0,
            withBrand: withBrand
        });
    };

    handleModelChange = event => {
        this.setState({
            selectedModelId: event.target.value
        })
    };
    
    handleRegisteredChange = event => {
      this.setState({
         isRegistered: event.target.value 
      });
    };
    
    render() {
        const brands = this.state.brands.map(brand => {
            return <MenuItem key={brand.id} value={brand.id}>{brand.name}</MenuItem>
        });
        
        let models = null;
        
        if (this.state.withBrand) {
            models = this.state.models.map(model => {
                return <MenuItem key={model.id} value={model.id}>{model.name}</MenuItem>
            });
        }
        
        return (
            <Grid container justify="flex-start">
                <form className={this.styles.root}>
                    <Grid item xs={12}>
                        <BrandsItem
                            valueSelected={this.state.selectedBrandId}
                            changeBrand={this.handleBrandChange}
                            brandsList={brands}
                        />
                        <ModelsItem
                            valueSelected={this.state.selectedModelId}
                            changeModel={this.handleModelChange}
                            modelsList={models}
                            isActive={this.state.withBrand}
                        />
                    </Grid>
                    <Grid item xs={12}>
                        <RegisteredItem
                            isRegistered={this.state.isRegistered}
                            changeRegister={this.handleRegisteredChange}
                        />
                    </Grid>
                    <Grid item xs={12}>
                        Hello from features
                    </Grid>
                </form>
            </Grid>
        );
    }
}

export default VehicleForm;
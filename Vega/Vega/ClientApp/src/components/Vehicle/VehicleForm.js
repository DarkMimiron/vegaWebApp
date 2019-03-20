import React, {Component} from 'react';
import {Checkbox, FormControlLabel, Grid, MenuItem} from "@material-ui/core";
import axios from "axios";

import BrandsItem from './VehicleFormItems/BrandsItem';
import ModelsItem from './VehicleFormItems/ModelsItem';
import RegisteredItem from './VehicleFormItems/RegisteredItem';
import FeaturesItem from './VehicleFormItems/FeaturesItem';

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
        isRegistered: "no",
        features: [],
        selectedFeatures: []
    };

    componentDidMount() {
        axios.get("/api/brands")
            .then(response => {
                this.setState({brands: response.data});
            });
        
        axios.get("/api/features")
            .then(response => {
                this.setState({features: response.data});
                let featuresData = response.data.map(feature => {
                    return {
                        id: feature['id'],
                        name: feature['name'],
                        selected: feature['selected'] || false
                    }
                });
                this.setState({selectedFeatures: featuresData});
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
    
    handleFeatureChange = id => event => {
        let selectedFeatures = this.state.selectedFeatures;
        selectedFeatures[id-1].selected = event.target.checked;
        this.setState({selectedFeatures: selectedFeatures});    
    };
    
    render() {
        // Creation of brand items
        const brands = this.state.brands.map(brand => {
            return <MenuItem key={brand.id} value={brand.id}>{brand.name}</MenuItem>
        });
        
        let models = null;
        
        // Creation of model items
        if (this.state.withBrand) {
            models = this.state.models.map(model => {
                return <MenuItem key={model.id} value={model.id}>{model.name}</MenuItem>
            });
        }
        
        // Creation of feature items
        const features = this.state.selectedFeatures.map(feature => {
           return <Grid key={feature.id} item>
                <FormControlLabel
                    control={
                        <Checkbox 
                            checked={feature.selected} 
                            value={feature.id.toString()} 
                            onChange={this.handleFeatureChange(feature.id)} />
                    }
                    label={feature.name}
                />
            </Grid>
        });
        
        return (
            <Grid container direction="column">
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
                        <FeaturesItem
                            featuresList={features}
                        />
                    </Grid>
                </form>
            </Grid>
        );
    }
}

export default VehicleForm;
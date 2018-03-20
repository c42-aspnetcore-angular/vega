import { NgForm } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

import { VehicleService } from './../../services/vehicle.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent {
  makes: any[];
  models: any[];
  features: any[];
  vehicle: any = {};
  contact: any = {};

  constructor(private vehicleService: VehicleService) {
    this.vehicleService.getMakes().subscribe(makes =>
      this.makes = makes
    );

    this.vehicleService.getFeatures().subscribe(features =>
      this.features = features
    );
  }

  onMakeChange() {
    const selectedMake = this.makes.find(m => m.id === +this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

  onSubmit(f: NgForm) {
    console.log(f);
  }
}

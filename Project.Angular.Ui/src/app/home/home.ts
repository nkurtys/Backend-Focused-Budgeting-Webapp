import { Component } from '@angular/core';
import { ReactiveFormsModule, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-home',
  imports: [ReactiveFormsModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
    profileForm = new FormGroup({
        name: new FormControl(''),
        email: new FormControl(''),
    });
    onSubmit() {
        alert(this.profileForm.value.name + '|' + this.profileForm.value.email + ' was saved!');
    }
}

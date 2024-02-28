import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  username: string = '';
  password: string = '';
  
  constructor(private UserService: UserService, private router: Router) {
    
  }
  onSubmit() {
    // Implement your login logic here
    debugger;
    this.UserService.login(this.username, this.password).subscribe(
      (response) => {
        //console.log(response);
        localStorage.setItem('token', response.token);
        this.router.navigateByUrl('/home');
      },
      (error) => {
        Swal.fire({
          icon: "error",
          title: "Oops...",
          text: "Contraseña Incorrecta"
        });
      }
    );
  }
}

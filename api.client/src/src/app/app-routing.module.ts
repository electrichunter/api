import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { LoginComponent } from './login/login/login.component'; 
 
import { AnamenuComponent } from './anamenu/anamenu/anamenu.component';
import { AdminComponent } from './admin/admin/admin.component';

const routes: Routes = [

{ path: 'login', component: LoginComponent },
{path:'',component:AnamenuComponent},
{path:'admin',component:AdminComponent},


];


@NgModule({
  
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }


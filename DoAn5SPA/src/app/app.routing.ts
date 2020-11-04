import{RouterModule,Routes} from '@angular/router';
import{NgModule} from '@angular/core';
import { HomeComponent } from './home/home.component';
import { DetailsComponent } from './details/details.component';

const routes:Routes=[
    {path:'',component:HomeComponent/* , pathMatch:'full' */},
    {path:'home',component:HomeComponent},
    {path:':id',component:DetailsComponent},
    {path:'**',redirectTo:"/home"}
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRouting{
    
}
import { Injectable } from '@angular/core';
import { CanLoad, CanActivate, CanDeactivate } from '@angular/router';

@Injectable()

export class AuthGuardService implements CanLoad, CanActivate {
  
  canActivate():boolean{
    return false;
  }
  canLoad(): boolean { 
    return true;
  }
 
}

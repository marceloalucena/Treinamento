import { ErrorHandler } from '@angular/core';

import * as StackTrace from 'stacktrace-js';

export class GlobalErrorHandler implements ErrorHandler{
    handleError(error: any): void {
        console.log('Minha Classe de Tratamento de Erros');

    const message = error.message
       ? error.message
       : error.toString();

    StackTrace.fromError(error)
      .then(stackFrame =>{
        //console.log(stackFrame);
        const stackAsString = stackFrame
          .map(sf => sf.toString())
          .join('\n');
    
        console.log(message);   
        console.log(stackAsString);
    });
        throw Error;
    }
}

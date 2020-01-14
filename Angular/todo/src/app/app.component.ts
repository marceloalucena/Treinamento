import { Component } from '@angular/core';
import { Todo } from 'e2e/src/models/todo.models';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public mode = 'list'
  public todos: Todo[] = [];
  public title: String = 'Minhas Tarefas';
  public form: FormGroup;

  constructor(private fb: FormBuilder) {
    this.form = this.fb.group({
      title: ['', Validators.compose([
        Validators.minLength(3),
        Validators.maxLength(60),
        Validators.required,
      ])]
    });

    this.carregarStorage();
    /*
    this.todos.push(new Todo(1,'Passear com o Cachorro', false));
    this.todos.push(new Todo(1,'Ir ao Supermercado', false));
    this.todos.push(new Todo(1,'Cortar o Cabelo', true));
    this.todos.push(new Todo(1,'Aula de Bateria', false));
    this.todos.push(new Todo(1,'Aniversário do Enrico', false));
    */
  }

  adicionarTodo(){
    const title = this.form.controls['title'].value;
    const id = this.todos.length+1;
    this.todos.push(new Todo(id, title, false));
    this.salvarStorage();
    this.limpar();
  }

  limpar(){
    this.form.reset();
  }

  removerTodo(todo: Todo){
    const index = this.todos.indexOf(todo);
    if(index !== -1){
      this.todos.splice(index,1);
    }
    this.salvarStorage();
  }
  
  concluirTodo(todo: Todo){
    todo.done = true;
    this.salvarStorage();
  }
  
  refazerTodo(todo: Todo){
    todo.done = false;
    this.salvarStorage();
  }

  salvarStorage(){
    const data = JSON.stringify(this.todos);
    localStorage.setItem('todos',data);
    this.mode = 'list';
  }

  carregarStorage(){
    const data =  localStorage.getItem('todos');
    this.todos = JSON.parse(data);
  }
  changeMode(mode: string){
    this.mode = mode;
  }
}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'Scool-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.css']
})
export class PerfilComponent implements OnInit {
  public titulo = 'Perfil';
  public acesso = true;
  public perfils = [
    'Aluno',
    'Professor'
  ]
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

}

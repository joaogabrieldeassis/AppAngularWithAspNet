import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'Scool-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
  public tituloDaPagina = 'Pagina Professores'
  public nomeDoProfessor = '';
  public idDoProfessor = '';
  public professores = [
    { id: 1, nome: 'Erika', discisplina: 'Matematica' },
    { id: 2, nome: 'Jeosvaldo', discisplina: 'Portugues' },
    { id: 3, nome: 'Marcia', discisplina: 'Historia' },
    { id: 4, nome: 'Diogo', discisplina: 'Geografia' }
  ]
  selectProf(professor: any) {
    this.nomeDoProfessor = professor.nome;
    this.idDoProfessor = professor.id;
  }
  voltarProf() {
    this.nomeDoProfessor = '';
    this.idDoProfessor = '';
  }
}

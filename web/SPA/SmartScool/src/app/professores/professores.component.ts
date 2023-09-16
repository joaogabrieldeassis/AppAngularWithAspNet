import { Component, OnInit, TemplateRef } from '@angular/core';
import { Professor } from '../Models/Professor';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'Scool-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
  public modalRef?: BsModalRef;
  public tituloDaPagina = 'Pagina Professores'
  public professorForm: FormGroup;
  public professorSelecionado: Professor | null = null;

  public professores: Professor[] = [
    { id: 1, nome: 'Erika', disciplina: 'Matematica' },
    { id: 2, nome: 'Jeosvaldo', disciplina: 'Portugues' },
    { id: 3, nome: 'Marcia', disciplina: 'Historia' },
    { id: 4, nome: 'Diogo', disciplina: 'Geografia' }
  ]
 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }
  
  constructor(private fomulario: FormBuilder,private modalService: BsModalService) {
    this.criarForm();
  }

  criarForm() {
    this.professorForm = this.fomulario.group({
      nome: ["", Validators.required],
      disciplina: ["", Validators.required]
    })
  }
  professorSubmit() {
    console.log(this.professorForm.value);
  }
  selectProf(professor: Professor) {
    this.professorSelecionado = professor;
    this.professorForm.patchValue(professor);
  }
  voltarProf() {
    this.professorSelecionado = null
  }
}

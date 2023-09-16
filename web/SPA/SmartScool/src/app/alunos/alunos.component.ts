import { Component, OnInit, TemplateRef } from '@angular/core';
import { Aluno } from '../Models/Aluno';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'Scool-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {
  ngOnInit(): void {

  }
  public modalRef?: BsModalRef;
  public alunoForm: FormGroup;
  titulo = 'Alunos';
  public alunoSelecionado: Aluno | null = null;
  public textSimple = "";
  public alunos: Aluno[] = [
    { id: 1, nome: 'João', sobrenome: 'Gabriel', telefone: '23345345' },
    { id: 2, nome: 'Mary', sobrenome: 'Pereira', telefone: '22345345' },
    { id: 3, nome: 'José', sobrenome: 'Augusto', telefone: '23345335' },
    { id: 4, nome: 'Clarice', sobrenome: 'Teixeira', telefone: '23345745' },
    { id: 5, nome: 'Tati', sobrenome: 'Cristina', telefone: '23375345' },
    { id: 6, nome: 'Diego', sobrenome: 'Cunhado', telefone: '23365345' }
  ]
 
 
 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }
    constructor(private formulario: FormBuilder,
                private modalService: BsModalService) {
    this.criarForm();
    }

  criarForm() {
    this.alunoForm = this.formulario.group({
      nome: ["", Validators.required],
      sobrenome: ["", Validators.required],
      telefone: ["", Validators.required]
    });
  }
  alunoSubmit() {
    console.log(this.alunoForm.value)
  }
  alunoSelect(aluno: Aluno) {
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno);
  }
  voltar() {
    this.alunoSelecionado = null;
  }
}

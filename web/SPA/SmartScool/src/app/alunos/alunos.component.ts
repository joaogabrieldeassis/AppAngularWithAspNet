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
    { Id: '1', Nome: 'João', Sobrenome: 'Gabriel', Telefone: '23345345' },
    { Id: '2', Nome: 'Mary', Sobrenome: 'Pereira', Telefone: '22345345' },
    { Id: '3', Nome: 'José', Sobrenome: 'Augusto', Telefone: '23345335' },
    { Id: '4', Nome: 'Clarice', Sobrenome: 'Teixeira', Telefone: '23345745' },
    { Id: '5', Nome: 'Tati', Sobrenome: 'Cristina', Telefone: '23375345' },
    { Id: '6', Nome: 'Diego', Sobrenome: 'Cunhado', Telefone: '23365345' }
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

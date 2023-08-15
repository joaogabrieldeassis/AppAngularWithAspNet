import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'Scool-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
  titulo = 'Alunos';
  public alunoSelecionado = "";
  public maryEspecial = '';
  public alunos = [
    { id: 1, nome: 'João', sobrenome: 'Gabriel', telefone: '23345345' },
    { id: 2, nome: 'Mary', sobrenome: 'Pereira', telefone: '22345345' },
    { id: 3, nome: 'José', sobrenome: 'Augusto', telefone: '23345335' },
    { id: 4, nome: 'Clarice', sobrenome: 'Teixeira', telefone: '23345745' },
    { id: 5, nome: 'Tati', sobrenome: 'Cristina', telefone: '23375345' },
    { id: 6, nome: 'Diego', sobrenome: 'Cunhado', telefone: '23365345' }
  ]
  alunoSelect(aluno: any) {
    this.alunoSelecionado = aluno.nome;
    if (aluno.nome == 'Mary') {
      this.maryEspecial = 'Você é muitooooooooooooooooooo lindaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
    }
    else {
      this.maryEspecial = '';
    }
  }
  voltar() {
    this.alunoSelecionado = '';
  }
}

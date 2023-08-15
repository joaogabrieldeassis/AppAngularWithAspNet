import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'Scool-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export default class DashboardComponent implements OnInit {
  public titulo = 'Dashboard';
  public statusDoAgendamento = [
    'confirmado',
    'negado'
  ]
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

}

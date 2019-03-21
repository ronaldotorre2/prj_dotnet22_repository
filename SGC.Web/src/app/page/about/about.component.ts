import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss']
})
export class AboutComponent implements OnInit {
  public title = 'Sobre o sistema';
  public paragrafo1 = 'O SGC - Sistema de gerenciamento comercial, foi planejado para atender ' +
                      'as áreas de comércio, sendo varejo e atacado, assim conforme a configuração ' +
                      'definida para a empresa ou loja contratante. Toda a configuração é efetuada ' +
                      'pelo administrador geral do sistema.';

  public paragrafo2 = 'O sistema possui módulos: ';
  public listaModule = ['Cadastros', 'Estoque', 'Financeiro', 'Pedidos', 'Relatórios'];

  constructor() { }

  ngOnInit() {
  }

}

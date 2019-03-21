import { Component, OnInit } from '@angular/core';
import { Constant } from 'src/app/shared/constant';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  public title = Constant.APP_INITIAL;
  public environment = '(Ambiente de teste)';
  public UserLogin = 'Usuário';

  constructor() {
  }

  ngOnInit() {
  }

}

import { error } from "@angular/compiler/src/util";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Usuario } from "../../model/usuario";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spiner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
        
  }
    ngOnInit(): void {
      this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }

  entrar() {
    this.ativar_spiner = true;
    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        usuario_json => {
          //var usuarioRetorno: Usuario;
          //usuarioRetorno = data;
          //sessionStorage.setItem("usuario-autenticado", "1");
          //sessionStorage.setItem("email-usuario", usuarioRetorno.email);
          this.usuarioServico.usuario = usuario_json;
          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          } else {
            this.router.navigate([this.returnUrl]);
          }
      },
        err => {
          console.log(error);
          this.mensagem = err.error;
          this.ativar_spiner = false;
      });

    /*if (this.usuario.email == "gabriel@teste.com" && this.usuario.senha == "abc123") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }*/
  }
}

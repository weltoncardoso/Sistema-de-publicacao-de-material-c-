using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtpsEtapa2.dominio
{
    class usuarios
    {
        private int codigo;

        private string login;

        private string senha;

        private string tipoUsuario;

        public usuarios()

        {
        }

        public usuarios(int codigo, string login, string senha, string tipoUsuario)

        {

            this.codigo = codigo;

            this.login = login;

            this.senha = senha;

            this.tipoUsuario = tipoUsuario;

        }

        public int Codigo

        {

            get { return codigo; }

            set { codigo = value; }

        }

        public string Login

        {

            get { return login; }

            set { login = value; }

        }

        public string Senha

        {

            get { return senha; }

            set { senha = value; }

        }

        public string TipoUsuario

        {

            get { return tipoUsuario; }

            set { tipoUsuario = value; }

        }

    }

}



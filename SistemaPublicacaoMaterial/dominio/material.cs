using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtpsEtapa2.dominio
{
    class material

    {

        private int codigo;

        private string departamento;

        private DateTime data;

        private string titulo;

        private string cliente;

        public material()

        {

        }

        public material(int codigo, string departamento,

        DateTime data, string titulo, string cliente)

        {

            this.codigo = codigo;

            this.departamento = departamento;

            this.data = data;

            this.titulo = titulo;

            this.cliente = cliente;

        }

        public int Codigo

        {

            get { return codigo; }

            set { codigo = value; }

        }

        public int Departamento

        {

            get { return Departamento; }

            set { Departamento = value; }

        }

        public DateTime Data

        {

            get { return data; }

            set { data = value; }

        }

        public string Titulo

        {

            get { return titulo; }

            set { titulo = value; }

        }

        public string Cliente

        {

            get { return cliente; }

            set { cliente = value; }

        }

    }

}



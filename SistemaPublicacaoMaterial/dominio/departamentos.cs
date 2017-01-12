using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtpsEtapa2.dominio
{
    
        class departamentos

        {

            private int codigo;

            private string descricao;

            public departamentos()

            {

            }

            public departamentos(int codigo, string descricao)

            {

                this.codigo = codigo;

                this.descricao = descricao;

            }

            public int Codigo

            {

                get { return codigo; }

                set { codigo = value; }

            }

            public string Descricao

            {

                get { return descricao; }

                set { descricao = value; }

            }

        }

    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
      

        public bool Logar(IAutenticavel autenticavel, string login, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(login,senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo Ao Sistema ");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou Senha incorreto ");
                return false;
            }

        }     


    }
}


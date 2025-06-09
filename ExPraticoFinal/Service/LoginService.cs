using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Repository;

namespace Service
{
    public class LoginService
    {
        LoginRepository loginRepository = new LoginRepository();

        public List<LoginEntities> ValidarLogin(string user, string senha)
        {
            List<LoginEntities>  usuario = loginRepository.ValidarLogin(user, senha);
            return usuario;
        }
    }
}

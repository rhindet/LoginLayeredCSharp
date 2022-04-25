using DataAcces;
using Common.cache;
using System.Data;

namespace domain
{
    public class UserModel
    {   
        private UserDao ObjetoCl = new UserDao();
        private UserDao ObjetoCh = new UserDao();
        public DataTable MostrarClien()
        {

            DataTable tabla = new DataTable();
            tabla = ObjetoCl.Mostrar_clientes();
            return tabla;
        }
        public DataTable MostrarEmple()
        {

            DataTable tabla = new DataTable();
            tabla = ObjetoCl.Mostrar_empleados();
            return tabla;
        }

        public DataTable MostrarSueld()
        {

            DataTable tabla = new DataTable();
            tabla = ObjetoCl.MostrarSueldos();
            return tabla;
        }
        public void EliminarSueldos()
        {

            ObjetoCl.EliminarSueldos();

        }

        UserDao userDao = new UserDao();
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;
        private int telefono;


        public UserModel(int idUser,string loginName, string password,string firstName , string lastName,string position , string email,int telefono)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;   
            this.firstName = firstName; 
            this.lastName = lastName;
            this.position = position;
            this.email = email;
            this.telefono = telefono;
        }
        public UserModel()
        {
           
        }
      




        public string editUserProfile()
        {
            
            try
            {
                userDao.editProfile(idUser, loginName, password, firstName, lastName, email, telefono);
                LoginUser(loginName, password);
                return "Tu perfil ha sido actualizado";
            }
           catch (Exception ex)
            {

                return "Usuario ya registrado";
            }
        }
        public bool LoginUser(string user, string pass) {
            return userDao.Login(user,pass);
        }

       

        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrador)
            {

            }
            if (UserLoginCache.Position == Positions.Manager)
            {

            }
        }
        public void InsertarUsuario(string userName, string password, string name, string lastName, string Email,string Position, int telefono)
        {

            ObjetoCh.InsertarUsuarios(userName, password, name, lastName, Email, Position, Convert.ToInt32(telefono));

        }

    }
}

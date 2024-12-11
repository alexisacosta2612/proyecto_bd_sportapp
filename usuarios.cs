using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto__
{
    public class usuarios
    {
        private int id;
        private string name;
        private string cuenta;
        private string contraseña;
        private int monto;

        public usuarios()
        {

        }
        //...
        public usuarios(int id,string name,string cuenta,string contraseña,int monto)
        {
            this.Id = id;
            this.Name = name;
            this.Cuenta = cuenta;
            this.Contraseña = contraseña; 
            this.Monto = monto;
            
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}

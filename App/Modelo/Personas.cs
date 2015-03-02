using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Personas
    {
         private String id;
         private String nombre;
         private String direccion;
         private String telefono;
         private String email;
  
  public Personas (String i, String n, String d, String t, String e){
    
      this.id = i;
      this.nombre = n;
      this.direccion = d;
      this.telefono = t;
      this.email = e;
        }

        public String toString()
        {
            return null;
        }

        public String nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
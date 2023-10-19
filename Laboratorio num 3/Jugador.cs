using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_num_3
{
    internal class Jugador
    {

        String nombre;
        String correo;
        String endulzadaIdeal;
        String regaloIdeal;
        String amigoSecreto;

        public Jugador(String nombre, String correo, String endulzadaIdeal, String regaloIdeal)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.endulzadaIdeal = endulzadaIdeal;
            this.regaloIdeal = regaloIdeal;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getCorreo()
        {
            return correo;
        }
        public String getEndulzadaIdeal()
        {
            return endulzadaIdeal;
        }

        public String getRegaloIdeal()
        {
            return regaloIdeal;
        }

        public String getAmigoSecreto()
        {
            return amigoSecreto;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }

        public void setEndulzadaIdeal(String endulzadaIdeal)
        {
            this.endulzadaIdeal = endulzadaIdeal;
        }

        public void setRegaloIdeal(String regaloIdeal)
        {
            this.regaloIdeal = regaloIdeal;
        }

        public void setAmigoSecreto(String amigo)
        {
            this.amigoSecreto = amigo;
        }

        public String mostrarJugador()
        {
            return "Jugador: " + this.nombre + ", " + this.correo + ", " + this.endulzadaIdeal + ", " + this.regaloIdeal;
        }

    }
}

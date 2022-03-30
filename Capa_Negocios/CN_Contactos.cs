using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Accesso_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class CN_Contactos
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        CAD_Contactos objDatatos = new CAD_Contactos();

        public List<CE_Contactos>ListarContacto(String buscar)
        {
            return objDatatos.ListarContactos(buscar);
        }

        public void InsertarContacto(CE_Contactos Contacto) {

            objDatatos.InsertarContacto(Contacto);
        }

        public void EditarContacto(CE_Contactos Contacto)
        {

            objDatatos.EditarContacto(Contacto);
        }

        public void EliminarContacto(CE_Contactos Contacto)
        {

            objDatatos.EliminarContacto(Contacto);
        }
    }
}

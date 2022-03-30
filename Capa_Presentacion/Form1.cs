using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Accesso_Datos;
using Capa_Entidad;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Form_Presentacion : Form
    {

        private String IdContacto;

        private bool Editarse = false;

        CE_Contactos ObjectoEntidad = new CE_Contactos();

        CN_Contactos ObjectoNegocio = new CN_Contactos();


        public Form_Presentacion()
        {
            InitializeComponent();
        }

        private void ExitPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Presentacion_Load(object sender, EventArgs e)
        {
            MostarBuscarTabla("");

            EditTable();
        }



        public void EditTable()
        {
            TablaContactos.Columns[0].Visible = false;

            

            TablaContactos.ClearSelection();
        }

        public void MostarBuscarTabla(String buscar)
        {

            CN_Contactos ObjectoNegocio = new CN_Contactos();

            TablaContactos.DataSource = ObjectoNegocio.ListarContacto(buscar);

            TablaContactos.ClearSelection();

        }

        private void TextBuscar_TextChanged(object sender, EventArgs e)
        {
            MostarBuscarTabla(TextBuscar.Text);
        }

        private void LimpiarCampos()
        {
            TextCode.Text = "";

            TextNombre.Text = "";

            TextApellido.Text = "";

            TextDir.Text = "";

            TextDate.Text = "";

            TextPhone.Text = "";

            TextCode.Enabled = false;

            TextNombre.Enabled = false;

            TextApellido.Enabled = false;

            TextDir.Enabled = false;

            TextDate.Enabled = false;

            TextPhone.Enabled = false;

            Editarse = false;

            btnGuardarContacto.Enabled = false;

        }

        private void btnAddContacto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            TextCode.Text = "Auto-Generado";

            TextNombre.Enabled = true;

            TextApellido.Enabled = true;

            TextDir.Enabled = true;

            TextDate.Enabled = true;

            TextPhone.Enabled = true;


            btnGuardarContacto.Enabled = true;

            TextNombre.Focus();
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            if (TablaContactos.SelectedRows.Count > 0)
            {

                Editarse = true;

                IdContacto = TablaContactos.CurrentRow.Cells[0].Value.ToString();

                TextCode.Text = TablaContactos.CurrentRow.Cells[1].Value.ToString();

                TextNombre.Text = TablaContactos.CurrentRow.Cells[2].Value.ToString();

                TextApellido.Text = TablaContactos.CurrentRow.Cells[3].Value.ToString();

                TextDir.Text = TablaContactos.CurrentRow.Cells[4].Value.ToString();

                TextDate.Text = TablaContactos.CurrentRow.Cells[5].Value.ToString();

                TextPhone.Text = TablaContactos.CurrentRow.Cells[6].Value.ToString();



                TextNombre.Enabled = true;

                TextApellido.Enabled = true;

                TextDir.Enabled = true;

                TextDate.Enabled = true;

                TextPhone.Enabled = true;

                btnGuardarContacto.Enabled = true;


            }

            else
            {

                MessageBox.Show("Seleccione La Fila Que Quiere Editar", "Editar Fila");
            }
        }

        private void btnGuardarContacto_Click(object sender, EventArgs e)
        {

            if (TextNombre.Text == "" || TextApellido.Text == "" || TextDir.Text == "" || TextDate.Text == "" || TextPhone.Text == "") {


                MessageBox.Show("Complete Todos Los Campos Para Guardar Los Cambios", "Campos Vacios");

                return;

            }


            if (Editarse == false)
            {

                try
                {

                    ObjectoEntidad.NombreContacto = TextNombre.Text.ToUpper();

                    ObjectoEntidad.ApellidoContacto = TextApellido.Text.ToUpper();

                    ObjectoEntidad.DirrecionContacto = TextDir.Text.ToUpper();

                    ObjectoEntidad.NacimientoContacto = TextDate.Text.ToUpper();

                    ObjectoEntidad.TelefonoContacto = TextPhone.Text.ToUpper();

                    ObjectoNegocio.InsertarContacto(ObjectoEntidad);

                    MessageBox.Show("El Registro Fue Guardado Correctamente", "Registro Guardado");

                    MostarBuscarTabla("");

                    TablaContactos.ClearSelection();

                    LimpiarCampos();


                }
                catch (Exception ex)
                {


                    MessageBox.Show("El Registro No Pudo Guardarse" + ex, "Error: Registro No Guardado");


                }



            }

            if (Editarse == true)
            {

                try
                {
                    ObjectoEntidad.CodeContacto = TextCode.Text;

                    ObjectoEntidad.NombreContacto = TextNombre.Text.ToUpper();

                    ObjectoEntidad.ApellidoContacto = TextApellido.Text.ToUpper();

                    ObjectoEntidad.DirrecionContacto = TextDir.Text.ToUpper();

                    ObjectoEntidad.NacimientoContacto = TextDate.Text.ToUpper();

                    ObjectoEntidad.TelefonoContacto = TextPhone.Text.ToUpper();

                    ObjectoNegocio.EditarContacto(ObjectoEntidad);

                    MessageBox.Show("El Registro Fue Actualizado Correctamente", "Registro Actualizado");

                    MostarBuscarTabla("");

                    LimpiarCampos();

                    TablaContactos.ClearSelection();

                    Editarse = false;


                }
                catch (Exception ex)
                {


                    MessageBox.Show("El Registro No Pudo Actualizarse" + ex, "Error: Registro No Actualizado");


                }
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {

            if (TablaContactos.SelectedRows.Count > 0)
            {

                ObjectoEntidad.CodeContacto = TablaContactos.CurrentRow.Cells[1].Value.ToString();

                ObjectoNegocio.EliminarContacto(ObjectoEntidad);

                MessageBox.Show("El Registro Fue Eliminado Correctamente","Registro Eliminado");

                MostarBuscarTabla("");

                LimpiarCampos();

                TablaContactos.ClearSelection();

            }

            else
            {
                MessageBox.Show("Seleccione La Fila Que Quiere Eliminar", "Eliminar Fila");
            }

        }

       
    }
}

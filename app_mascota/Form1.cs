using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioMascota;

namespace app_mascota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColeccionMascotas.CargarDatosPrueba();
            RefrescarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValiCamp();
            Mascota mascota = new Mascota();
            try
            {
                mascota.Id = int.Parse(txId.Text);
                mascota.Nombre = txNombre.Text;
                mascota.Sexo = cbSexo.Text;
                mascota.Raza = txRaza.Text;
                mascota.Vacunado = cbVacunas.Checked;
                mascota.FechaNacim = dtFecha.Value;
                mascota.tamano = cbTamano.Text;
                mascota.NomPro = txNomPro.Text;
                mascota.EdadPro = int.Parse(txEdadPro.Text);
                if (mascota.Validar())
                {
                    if (ColeccionMascotas.Create(mascota))
                    {
                        MessageBox.Show("Mascota creada","Completado");
                        dgTabla.DataSource = ColeccionMascotas.ReadAll();
                        dgTabla.Refresh();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("La ID ya esta usada", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Faltan datos por ingresar", "Advertencia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idBuscado = int.Parse(txId.Text);
            Mascota buscada = ColeccionMascotas.Read(idBuscado);
            if (buscada == null)
            {
                MessageBox.Show("La ID no fue encontrada", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txNombre.Text = buscada.Nombre;
            cbSexo.Text = buscada.Sexo;
            txRaza.Text = buscada.Raza;
            cbVacunas.Text = buscada.Vacunado.ToString();
            dtFecha.Text = buscada.FechaNacim.ToString();
            cbTamano.Text = buscada.tamano;
            txNomPro.Text = buscada.NomPro;
            txEdadPro.Text = buscada.EdadPro.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ValiCamp();
            Mascota mascota = new Mascota();
            try
            {
                mascota.Id = int.Parse(txId.Text);
                mascota.Nombre = txNombre.Text;
                mascota.Sexo = cbSexo.Text;
                mascota.Raza = txRaza.Text;
                mascota.Vacunado = cbVacunas.Checked;
                mascota.FechaNacim = dtFecha.Value;
                mascota.tamano = cbTamano.Text;
                mascota.NomPro = txNomPro.Text;
                mascota.EdadPro = int.Parse(txEdadPro.Text);
                if (mascota.Validar())
                {
                    if (ColeccionMascotas.Update(mascota))
                    {
                        MessageBox.Show("Modificacion hecha","Completado");
                        RefrescarGrid();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("La ID ya esta usada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Faltan datos por ingresar", "Advertencia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de eliminar","eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int idBuscado = int.Parse(txId.Text);
                Mascota eliminada = ColeccionMascotas.Delete(idBuscado);
                if (eliminada == null)
                {
                    MessageBox.Show("Id no encontrado, no se logro eliminar");
                    return;
                }
                else
                {
                    MessageBox.Show("Elimiado");
                    RefrescarGrid();
                }
            }
        }
        public void Limpiar()
        {
            txId.Text = "";
            txNombre.Text = "";
            cbSexo.Text = "";
            txRaza.Text = "";
            cbVacunas.Checked = false;
            dtFecha.Text = "";
            cbTamano.Text = "";
            txNomPro.Text = "";
            txEdadPro.Text = "";
        }
        public void RefrescarGrid()
        {
            dgTabla.DataSource = ColeccionMascotas.ReadAll();
            dgTabla.Refresh();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        public bool ValiCamp()
        {
            bool er = true;
            if (txId.Text == "")
            {
                er = false;
                errorProvider1.SetError(txId, "Debe ingresar Id");
            }
            if (txNombre.Text == "")
            {
                er = false;
                errorProvider1.SetError(txNombre, "Debe ingresar nombre");
            }
            if (cbSexo.Text == "")
            {
                er = false;
                errorProvider1.SetError(cbSexo, "Debe ingresar sexo");
            }
            if (txRaza.Text == "")
            {
                er = false;
                errorProvider1.SetError(txRaza, "Debe ingresar raza");
            }
            DateTime da = new DateTime();
            if (da == DateTime.Today)
            {
                errorProvider1.SetError(dtFecha, "Debe ingresar fecha");
            }
            if (cbTamano.Text == "")
            {
                er = false;
                errorProvider1.SetError(cbTamano, "Debe ingresar tamaño");
            }
            if (txNomPro.Text == "")
            {
                er = false;
                errorProvider1.SetError(txNomPro, "Debe ingresar nombre del propietario");
            }
            if (txEdadPro.Text == "")
            {
                er = false;
                errorProvider1.SetError(txEdadPro, "Debe ingresar edad del propietario");
            }
            return er;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSexo.Items.Add("Macho");
            cbSexo.Items.Add("Hembra");

            cbTamano.Items.Add("Pequeño");
            cbTamano.Items.Add("Mediano");
            cbTamano.Items.Add("Grande");
        }
    }
}

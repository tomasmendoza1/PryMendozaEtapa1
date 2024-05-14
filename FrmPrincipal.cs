using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaEtapa1
{
    public partial class FrmPrincipal : Form
    {
        public Bitmap mousemap; //public bit map 
        public FrmPrincipal()
        {
            InitializeComponent();
            mousemap = new Bitmap(ptcRegistrarFirmar.Width, ptcRegistrarFirmar.Height); // bit map = ptc location
            ptcRegistrarFirmar.Image = mousemap;
        }

        bool EstadoDeMouse;//up y down
        Point CordenadasDelFormulario;

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            BtnComenzar.Enabled = false; //desactivar
            BtnGuardar.Enabled = true;   //activar
        }

        private void ptcRegistrarFirmar_MouseDown(object sender, MouseEventArgs e)
        {
            EstadoDeMouse = true; //activar
            CordenadasDelFormulario = e.Location; // e location = donde esta el mouse 
        }

        private void ptcRegistrarFirmar_MouseUp(object sender, MouseEventArgs e)
        {
            EstadoDeMouse = false;
        }

        private void ptcRegistrarFirmar_MouseMove(object sender, MouseEventArgs e)
        {
            if (EstadoDeMouse == true)
            {
                using(Graphics g = ptcRegistrarFirmar.CreateGraphics())
                {
                    using(Pen ObjetoLapiz = new Pen(Color.Black, 3))
                    {
                        g.DrawLine(ObjetoLapiz, CordenadasDelFormulario, e.Location);
                        CordenadasDelFormulario = e.Location;
                    }
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string RutaDeFirmas = Path.Combine(Application.StartupPath, "FirmasRegistradas"); //carpeta 
                if (!Directory.Exists(RutaDeFirmas))
                {
                    Directory.CreateDirectory(RutaDeFirmas);
                }
                string archivo = $"{DateTime.Now.ToString("yyyy-MM-dd hhmmss")}.png"; //dia mes año segundos 
                string destino = Path.Combine(RutaDeFirmas, archivo); //
                mousemap.Save(destino, System.Drawing.Imaging.ImageFormat.Png); //formato 
                MessageBox.Show("Ha registrado con éxito su firma!");
                ptcRegistrarFirmar.Invalidate();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

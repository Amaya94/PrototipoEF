using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_Seguridad
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        public Menup()
        {
            InitializeComponent();

            Button[] apps = { btnseguridad, btlogistica};
            cn.deshabilitarApps(apps);

            cn.getAccesoApp(1000, apps[0]);
            cn.getAccesoApp(8000, apps[1]);
           

        }

        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            cn.setBtitacora("1000", "Ingreso Seguridad");
            //this.Close();
        }

        public void btlogistica_Click(object sender, EventArgs e)
        {
            Capa_vistahoteleria.Nuevo_MDI b = new Capa_vistahoteleria.Nuevo_MDI();
            b.Show();
            cn.setBtitacora("2000", "Ingreso Logistica");
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login b = new Login();
            cn.setBtitacora("999", "Cerro Sesion");
            b.Show();
            this.Close();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            ComprasVista.central_Compra b = new ComprasVista.central_Compra();
            b.Show();
            cn.setBtitacora("3000", "Ingreso Compras");
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            CapaVistaProduccion.inicio b = new CapaVistaProduccion.inicio();
           b.Show();
            cn.setBtitacora("5000", "Ingreso Produccion");
        }

        private void btnnominas_Click(object sender, EventArgs e)
        {
            //CapaVistaNomina.MenuPrincipal b = new CapaVistaNomina.MenuPrincipal();
            //b.Show();
            //cn.setBtitacora("6000", "Ingreso Nominas");
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
           Vista_Bancos.Banco_Form b = new Vista_Bancos.Banco_Form();
           b.Show();
           cn.setBtitacora("7000", "Ingreso Bancos");
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
           Capa_VistaContabilidad.Nuevo_MDI b = new Capa_VistaContabilidad.Nuevo_MDI();
           b.Show();
            cn.setBtitacora("8000", "Ingreso Contabilidad");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_vistahoteleria
{
    public partial class Nuevo_MDI : Form
    {
        Seguridad_Controlador.Controlador cnc = new Seguridad_Controlador.Controlador();
        public Nuevo_MDI()
        {
            InitializeComponent();
            customizeDesing();
            Button[] apps = { btn_RegCli, btn_RegHab,btn_ReservaHab};
            cnc.deshabilitarApps(apps);
            //mante clases
            cnc.getAccesoApp (8201,apps[0]);
            //Mantenimiento Encabezado Cuentas|
            cnc.getAccesoApp(8202, apps[1]);
            //Mantenimiento tipo cuenta

            // ----------- Procesos ---------

            cnc.getAccesoApp(8202, apps[2]);
            // Revision Presupuestos


        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelPolizas.Visible = false;
            panelActivos.Visible = false;
            panelPresupuestos.Visible = false;
            panelEstadosF.Visible = false;
            panelCierreC.Visible = false;
            panelMant.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPolizas.Visible == true)
                panelPolizas.Visible = false;
            if (panelActivos.Visible == true)
                panelActivos.Visible = false;
            if (panelPresupuestos.Visible == true)
                panelPresupuestos.Visible = false;
            if (panelEstadosF.Visible == true)
                panelEstadosF.Visible = false;
            if (panelCierreC.Visible == true)
                panelCierreC.Visible = false;
            if (panelMant.Visible == true)
                panelMant.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPolizas);
        }

        private void btnRecepción_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnRequisiciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesCompras_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelActivos);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            RegistroCliente regC = new RegistroCliente();
            regC.MdiParent = this;
            regC.StartPosition = FormStartPosition.CenterScreen;
            regC.Show();
            hideSubMenu();
        }

        private void btnContactoClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosCLientes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPresupuestos);
        }

        private void btnContactosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPagosDia_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReportesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMovimientosProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEstadosF);
        }


        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevolucionesVentas_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void central_Compra_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCierreC);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMant);
        }

        private void btn_CierrePC_Click(object sender, EventArgs e)
        {
            RegistroHabitacion regH = new RegistroHabitacion();
            regH.MdiParent = this;
            regH.StartPosition = FormStartPosition.CenterScreen;
            regH.Show();
            hideSubMenu();
        }

     


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btn_ConsultaInt_Click(object sender, EventArgs e)
        {
            Capa_VistaConsultas.Busqueda consultar = new Capa_VistaConsultas.Busqueda();
            consultar.MdiParent = this;
            consultar.StartPosition = FormStartPosition.CenterScreen;
            consultar.Show();
            hideSubMenu();
        }

    }
}

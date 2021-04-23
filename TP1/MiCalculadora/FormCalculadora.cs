using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// instancia dos numeros para ser operados con Operar
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>resultado de Operar.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero aux1 = new Numero(numero1);
            Numero aux2 = new Numero(numero2);
            //retorno valores.
            return Calculadora.Operar(aux1, aux2, operador);
        }
        /// <summary>
        /// Limpia forms
        /// </summary>
        private void Limpiar()
        {
            txtBoxNumero1.Clear();
            txtBoxNumero2.Clear();
            labelResultado.ResetText();
            comboBoxOperaciones.ResetText();
            btnBinario.Enabled = false;
            btnDecimal.Enabled = false;

        }
        /// <summary>
        /// Botón  que limpia el forms
        /// </summary>
     
        private void btnLimpiar_Click(object sender,EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// opera y muestra resultado (boton)
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e) 
        {
            labelResultado.Text = Convert.ToString(FormCalculadora.Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, comboBoxOperaciones.Text));
            btnBinario.Enabled = true;
            btnDecimal.Enabled = false;
        }

        /// <summary>
        /// carga por defecto parámetros.
        /// </summary>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            btnBinario.Enabled = false;
            btnDecimal.Enabled = false;
        }
        /// <summary>
        /// Cierra el form (boton)
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte el numero en binario (boton)
        /// </summary>
        private void btnBinario_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero();
            labelResultado.Text = binario.DecimalBinario(labelResultado.Text);
            btnDecimal.Enabled = true;
            btnBinario.Enabled = false;
        }

        /// <summary>
        /// Convierte el numero en dceimal (boton)
        /// </summary>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Numero numDecimal = new Numero();
            labelResultado.Text=numDecimal.BinarioDecimal(labelResultado.Text);
            btnDecimal.Enabled = false;
            btnBinario.Enabled = true;


        }

      
    }
}

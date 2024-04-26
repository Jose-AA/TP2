using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    internal class Validaciones
    {
        public static bool validarCajaVacia(TextBox caja)
        {
            if (string.IsNullOrWhiteSpace(caja.Text))
            {

                return true;
            }

            else
            {
                return false;
            }

        }

        public static bool validarEntero(TextBox caja)
        {
            int numero;

            if (int.TryParse(caja.Text, out numero))
            {

                return true;
            }
            else
            {

                return false;

            }
        }

        public static bool validarRangoNumerico(TextBox caja, int min, int max)
        {
            int numero;
            if (int.TryParse(caja.Text, out numero))
            {
                if (numero >= min && numero <= max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool validarFloat(TextBox caja)
        {
            float numero;
            if (float.TryParse(caja.Text, out numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarCamposObligatorios(Form formulario)
        {
            bool camposVacios = false;


            foreach (Control control in formulario.Controls)
            {

                if (control is TextBox textBox)
                {

                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {


                        camposVacios = true;
                    }

                }

            }

            return camposVacios;
        }

    }
}

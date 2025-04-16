using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProgessly.Helpers
{
    public class HelperValidator
    {
        public static bool ValidateCamp(TextBox campo, ErrorProvider errorProvider, Button buttom, Button button2)
        {
            string texto = campo.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                errorProvider.SetError(campo, "Debe introducir caracteres");
                buttom.Enabled = false;
                button2.Enabled = false;
                campo.Focus();
                return false;
            }

            if (!texto.All(char.IsLetter))
            {
                errorProvider.SetError(campo, "Este campo solo debe contener letras sin espacios");
                buttom.Enabled = false;
                button2.Enabled= false;
                campo.Focus();
                return false;
            }

            errorProvider.SetError(campo, string.Empty);
            buttom.Enabled = true;
            button2.Enabled = true;
            return true;
        }


        public static bool ValidateCampWithSpaces(TextBox campo, ErrorProvider errorProvider, Button buttom, Button button2)
        {
            string texto = campo.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                errorProvider.SetError(campo, "Debe introducir caracteres");
                buttom.Enabled = false;
                button2.Enabled = false;
                campo.Focus();
                return false;
            }

            if (!texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorProvider.SetError(campo, "Solo se permiten letras y espacios");
                buttom.Enabled = false;
                button2.Enabled = false;
                campo.Focus();
                return false;
            }

            errorProvider.SetError(campo, string.Empty);
            buttom.Enabled = true;
            button2.Enabled = true;
            return true;
        }


        public static bool ValidateOnlyNumbers(TextBox campo, ErrorProvider errorProvider, Button buttom, Button button2)
        {
            string texto = campo.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                errorProvider.SetError(campo, "Debe introducir un numero");
                buttom.Enabled = false;
                button2.Enabled = false;
                campo.Focus();
                return false;
            }

            if (!texto.All(char.IsDigit))
            {
                errorProvider.SetError(campo, "Solo se permiten numeros");
                buttom.Enabled = false;
                button2.Enabled = false;
                campo.Focus();
                return false;
            }

            errorProvider.SetError(campo, string.Empty);
            buttom.Enabled = true;
            button2.Enabled = true;
            return true;
        }
    }
}

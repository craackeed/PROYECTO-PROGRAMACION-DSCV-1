using System.Linq;

namespace PROYECTO_PROGRAMACION_DSCV__1
{
    public static class ValidacionCliente
    {
        public static string ValidarTelefono(string telefono)
        {
            if (telefono.Length != 8 || !telefono.All(char.IsDigit))
                return "El teléfono debe tener 8 dígitos";
            return "";
        }
    }
}
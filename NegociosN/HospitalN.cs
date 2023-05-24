using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesE;
using AccesoDatosD;

namespace NegociosN
{
    public class HospitalN
    {
        HospitalD hospitalD = new HospitalD();

        public bool? InsertarHospital(string @strNombre, string @strDireccion, string @strTelefono, int @intNcama)
        {
            hospitalD = new HospitalD();
            return hospitalD.InsertarHospital(strNombre, strDireccion, strTelefono, intNcama);
        }

        public List<HospitalE> ListadoHospital(string @strFiltro)
        {
            hospitalD = new HospitalD();
            return hospitalD.ListadoHospital(strFiltro);
        }

        public bool? ActualizarHospital(int @intCod_Hospital, string @strNombre, string @strDireccion, string @strTelefono, int @intNcama)
        {
            hospitalD = new HospitalD();
            return hospitalD.ActualizarHospital(intCod_Hospital, strNombre, strDireccion, strTelefono, intNcama);
        }

        public bool? EliminarHospital(int @intCod_Hospital)
        {
            hospitalD = new HospitalD();

            return hospitalD.EliminarHospital(intCod_Hospital);
        }

    }
}

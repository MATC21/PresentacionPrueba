using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesE;

namespace AccesoDatosD
{
    public class HospitalD
    {

        public bool? InsertarHospital(string @strNombre,string @strDireccion,string @strTelefono,int @intNcama)
        {
            bool? respuesta = false;

            try
            {
                using (HospitalEntities context = new AccesoDatosD.HospitalEntities())
                {
                    var sp = context.sp_insertar_hospital(strNombre,strDireccion,strTelefono,intNcama);
                    foreach (var item in sp)
                    {
                        respuesta = item.RESPUESTA;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return respuesta;
        }

        public List<HospitalE> ListadoHospital(string @Filtro)
        {
            List<HospitalE> Doc = new List<HospitalE>();
            using (HospitalEntities context = new AccesoDatosD.HospitalEntities())
            {
                var sp = context.sp_listar_hospital (@Filtro);
                foreach (var item in sp)
                {
                    HospitalE doc = new HospitalE();
                    doc.Hospital_Cod =(int)item.Hospital_Cod;
                    doc.Nombre = item.Nombre;
                    doc.Direccion = item.Direccion;
                    doc.Telefono = item.Telefono;
                    doc.Num_Cama = (int)item.Num_Cama;
                    Doc.Add(doc);
                }
            }
            return Doc;
        }

        public bool? ActualizarHospital(int @intCod_Hospital, string @strNombre, string @strDireccion, string @strTelefono, int @intNcama)
        {
            bool? respuesa = false;

            try
            {
                using (HospitalEntities context = new AccesoDatosD.HospitalEntities())
                {
                    var sp = context.sp_actualizar_hospital(intCod_Hospital, strNombre, strDireccion, strTelefono, intNcama);
                    foreach (var item in sp)
                    {
                        respuesa = item.Respuesta;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return respuesa;
        }

        public bool? EliminarHospital(int @intCod_Hospital)
        {
            bool? respuesa = false;

            try
            {
                using (HospitalEntities context = new AccesoDatosD.HospitalEntities())
                {
                    var sp = context.sp_eliminar_hospital(intCod_Hospital);
                    foreach (var item in sp)
                    {
                        respuesa = item.Respuesta;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return respuesa;
        }

    }
}

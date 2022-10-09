using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Configuration; 
using System.Data; 
using System.Data.SqlClient; 
using CL1_POO2_T4KB_Penadillo_Angelo.Models; 


namespace CL1_POO2_T4KB_Penadillo_Angelo.Controllers
{
    public class ConsultasDAO
    {
        string cad_cn =
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        public List<usp_consulta_ventas> ConsultaVentas()
        {
            List<usp_consulta_ventas> lista = new List<usp_consulta_ventas>();
            //
            SqlConnection cnx = new SqlConnection(cad_cn);
            cnx.Open();
            //
            SqlCommand cmd = new SqlCommand("usp_consulta_ventas", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            //
            SqlDataReader dr = cmd.ExecuteReader();
            //
            usp_consulta_ventas var_modelo = null;
            //
            while (dr.Read())
            {
                var_modelo = new usp_consulta_ventas()
                {
                    num_vta  = dr.GetString(0),
                    fec_vta  = dr.GetString(1),
                    nom_art  = dr.GetString(2),
                    precio   = dr.GetDecimal(3),
                    cantidad = dr.GetInt32(4),
                    Total    = dr.GetDecimal(5)
                };
                //
                lista.Add(var_modelo);
            }
            //
            dr.Close();
            //
            cnx.Close();
            //
            return lista;
        }
        public List<usp_ventas_años> ConsultaVentasAños(int year1, int year2)
        {
            List<usp_ventas_años> lista = new List<usp_ventas_años>();
            //
            SqlConnection cnx = new SqlConnection(cad_cn);
            cnx.Open();
            //
            SqlCommand cmd = new SqlCommand("usp_ventas_años", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            //
            cmd.Parameters.AddWithValue("@year1", year1);
            //
            cmd.Parameters.AddWithValue("@year2", year2);
            //
            SqlDataReader dr = cmd.ExecuteReader();
            //
            usp_ventas_años var_modelo = null;
            //
            while (dr.Read())
            {
                var_modelo = new usp_ventas_años()
                {
                    num_vta = dr.GetString(0),
                    fec_vta = dr.GetString(1),
                    tot_vta = dr.GetDecimal(2),
                    nom_ven = dr.GetString(3),
                    fecing_ven = dr.GetString(4)
                };
                //
                lista.Add(var_modelo);
            }
            //
            dr.Close();
            //
            cnx.Close();
            //
            return lista;
        }
        public List<usp_ventas_vendedor_año> Ventas_Vendedor_Año(int cod_ven, int year)
        {
            List<usp_ventas_vendedor_año> lista = new List<usp_ventas_vendedor_año>();
            //
            SqlConnection cnx = new SqlConnection(cad_cn);
            cnx.Open();
            //
            SqlCommand cmd = new SqlCommand("usp_ventas_vendedor_año", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            //
            cmd.Parameters.AddWithValue("@cod_ven", cod_ven);
            //
            cmd.Parameters.AddWithValue("@year", year);
            //
            SqlDataReader dr = cmd.ExecuteReader();
            //
            usp_ventas_vendedor_año var_modelo = null;
            //
            while (dr.Read())
            {
                var_modelo = new usp_ventas_vendedor_año()
                {
                    num_vta = dr.GetString(0),
                    fec_vta = dr.GetString(1),
                    nom_cli = dr.GetString(2),
                    tot_vta = dr.GetDecimal(3)
                };
                //
                lista.Add(var_modelo);
            }
            //
            dr.Close();
            //
            cnx.Close();
            //
            return lista;
        }
    }
}
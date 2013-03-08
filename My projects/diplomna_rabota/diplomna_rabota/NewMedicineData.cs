using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace diplomna_rabota
{
    class NewMedicineData
    {

         public static void addMedicine(Drug obj)
         {
             SqlConnection conn = new SqlConnection(global::diplomna_rabota.Properties.Settings.Default.DrugsConnectionString);
             conn.Open();
             SqlCommand cmd = new SqlCommand("AddNewMedicine", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@gName", obj.GenericName));
            cmd.Parameters.Add(new SqlParameter("@mName", obj.MedicineName));
            cmd.Parameters.Add(new SqlParameter("@producer", obj.Producer));
            cmd.Parameters.Add(new SqlParameter("@mForm", obj.MedForm));
            cmd.Parameters.Add(new SqlParameter("@NZOKCode", obj.NZOKCode));
           
            cmd.Parameters.Add(new SqlParameter("@action", obj.Action));
            
            cmd.Parameters.Add(new SqlParameter("@sideEff", obj.SideEffect));
            cmd.Parameters.Add(new SqlParameter("@ContraInd", obj.ContraIndication));
            cmd.Parameters.Add(new SqlParameter("@medD", obj.MedicineDescrip));
            cmd.Parameters.Add(new SqlParameter("@TerAg", obj.TerapyAgent));
            cmd.ExecuteNonQuery();
        }

         }
    }







 
            

           


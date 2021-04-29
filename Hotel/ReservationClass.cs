using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Hotel
{
    class ReservationClass
    {
        public int BookingID { get; set; }

        public string Name { get; set; }

        public string IDNumber { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string TypeRoom { get; set; }

        public string LengthStay { get; set; }

        public string CheckIn { get; set; }

        public string CheckOut { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_Reservation";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool Insert (ReservationClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Reservation(Name, IDNumber, Email, PhoneNumber, TypeRoom, CheckIn, CheckOut, LengthStay) VALUES (@Name, @IDNumber, @Email, @PhoneNumber, @TypeRoom, @CheckIn, @CheckOut, @LengthStay)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@IDNumber", c.IDNumber);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@TypeRoom", c.TypeRoom);
                cmd.Parameters.AddWithValue("@CheckIn", c.CheckIn);
                cmd.Parameters.AddWithValue("@CheckOut", c.CheckOut);
                cmd.Parameters.AddWithValue("@LengthStay", c.LengthStay);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }


            }

            catch(Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Edit(ReservationClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_Reservation SET Name=@Name, IDNumber=@IDNumber, Email=@Email, PhoneNumber=@PhoneNumber, TypeRoom=@TypeRoom, CheckIn=@CheckIn, CheckOut=@CheckOut, LengthStay=@LengthStay WHERE BookingID=@BookingID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@IDNumber", c.IDNumber);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@TypeRoom", c.TypeRoom);
                cmd.Parameters.AddWithValue("@CheckIn", c.CheckIn);
                cmd.Parameters.AddWithValue("@CheckOut", c.CheckOut);
                cmd.Parameters.AddWithValue("@LengthStay", c.LengthStay);
                cmd.Parameters.AddWithValue("@BookingID", c.BookingID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(ReservationClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_Reservation WHERE BookingID=@BookingID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@BookingID", c.BookingID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}

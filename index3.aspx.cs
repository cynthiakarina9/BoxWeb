using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BoxWeb
{
    public partial class index3 : System.Web.UI.Page
    {
        //"Data Source=serverappmynfo1.database.windows.net;Initial Catalog=Mynfo;Persist Security Info=True;User ID=adminmynfo;Password=4dmiNFC*Atx2020"
        public static string cadenaConexion = @"data source=serverappmynfo1.database.windows.net;initial catalog=mynfo;user id=adminmynfo;password=4dmiNFC*Atx2020;Connect Timeout=60";
        SqlConnection con = new SqlConnection(cadenaConexion);

        protected void Page_Load(object sender, EventArgs e)
        {

            try 
            {
                string user_id = Request.QueryString["user_id"];
                string Tag_id = Request.QueryString["tag_id"];
                int get_box_id = 0;

                if (user_id == null)
                {
                    user_id = "0";
                }

                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

                string queryLastBoxCreated =

                "select dbo.Users.FirstName, dbo.Users.LastName, dbo.Users.UserTypeId, dbo.Users.ImagePath, dbo.Boxes.BoxId from dbo.Users " +
                "join dbo.Boxes on(dbo.Boxes.UserId = dbo.Users.UserId) " +
                " where dbo.Users.UserId = " + user_id +
                " and dbo.Boxes.BoxDefault = 1";

                System.Text.StringBuilder sb;

                //http://localhost:58951/index.aspx?user_id=7

                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    sb = new System.Text.StringBuilder();
                    sb.Append(queryLastBoxCreated);

                    string sql = sb.ToString();

                    using (SqlCommand command3 = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command3.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string get_FirstName = (string)reader["FirstName"];
                                string get_LastName = (string)reader["LastName"];
                                string get_ImagePath = reader["ImagePath"].ToString();
                                get_box_id = (int)reader["BoxId"];
                                int UserTypeId_get = (int)reader["UserTypeId"];

                                Label_name.Text = get_FirstName + " " + get_LastName;

                                Image1.ImageUrl = "https://mynfoapi1.azurewebsites.net/" + get_ImagePath.TrimStart('~');
                            }
                        }
                        connection.Close();
                    }
                }


                //Creación de perfiles locales de box local
                string queryGetBoxEmail = "select * from dbo.ProfileEmails " +
                                "join dbo.Box_ProfileEmail on" +
                                "(dbo.ProfileEmails.ProfileEmailId = dbo.Box_ProfileEmail.ProfileEmailId) " +
                                "where dbo.Box_ProfileEmail.BoxId = " + get_box_id.ToString();

                string queryGetBoxPhone = "select * from dbo.ProfilePhones " +
                                            "join dbo.Box_ProfilePhone on" +
                                            "(dbo.ProfilePhones.ProfilePhoneId = dbo.Box_ProfilePhone.ProfilePhoneId) " +
                                            "where dbo.Box_ProfilePhone.BoxId = " + get_box_id.ToString();

                string queryGetBoxSMProfiles = "select * from dbo.ProfileSMs " +
                                                "join dbo.Box_ProfileSM on" +
                                                "(dbo.ProfileSMs.ProfileMSId = dbo.Box_ProfileSM.ProfileMSId) " +
                                                "join dbo.RedSocials on(dbo.ProfileSMs.RedSocialId = dbo.RedSocials.RedSocialId) " +
                                                "where dbo.Box_ProfileSM.BoxId = " + get_box_id.ToString();

                //Consulta para obtener perfiles email
                using (SqlConnection conn1 = new SqlConnection(cadenaConexion))
                {
                    sb = new System.Text.StringBuilder();
                    sb.Append(queryGetBoxEmail);

                    string sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, conn1))
                    {
                        conn1.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string Name = (string)reader["Name"];
                                string Email = (string)reader["Email"];

                                System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
                                new System.Web.UI.HtmlControls.HtmlGenericControl();
                                createDiv.InnerHtml = @" 

                                <div style=""display:inline-block;"">
                                    <a href=""" + Email + @""" target=""_blank""><img src=""Image social/Mail_icono.png"" style=""height: 84px; padding: 5px;""></a>
                                </div>  
                            ";
                                div1.Controls.Add(createDiv);
                            }
                        }
                        conn1.Close();
                    }
                }

                //Consulta para obtener perfiles teléfono
                using (SqlConnection conn1 = new SqlConnection(cadenaConexion))
                {
                    sb = new System.Text.StringBuilder();
                    sb.Append(queryGetBoxPhone);

                    string sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, conn1))
                    {
                        conn1.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int UserId = (int)reader["UserId"];
                                string ProfileName = (string)reader["Name"];
                                string value = (string)reader["Number"];

                                System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
                                new System.Web.UI.HtmlControls.HtmlGenericControl();
                                createDiv.InnerHtml = @" 

                                <div style=""display:inline-block;"">
                                    <a href=""" + value + @""" target=""_blank""><img src=""Image social/Tel_icono.png"" style=""height: 84px; padding: 5px;""></a>
                                </div>  
                            ";
                                div1.Controls.Add(createDiv);
                            }
                        }
                        conn1.Close();
                    }
                }

                //Consulta para obtener perfiles de redes sociales
                using (SqlConnection conn1 = new SqlConnection(cadenaConexion))
                {
                    sb = new System.Text.StringBuilder();
                    sb.Append(queryGetBoxSMProfiles);

                    string sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, conn1))
                    {
                        conn1.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ProfileName = (string)reader["ProfileName"];
                                string value = (string)reader["link"];
                                string ProfileType = (string)reader["Name"];

                                System.Web.UI.HtmlControls.HtmlGenericControl createDiv =
                                new System.Web.UI.HtmlControls.HtmlGenericControl();
                                createDiv.InnerHtml = @" 

                                <div style=""display:inline-block;"">
                                    <a href=""" + value + @""" target=""_blank""><img src=""Image social/" + ProfileType + @".png"" style=""height: 84px; padding: 5px;""></a>
                                </div>  
                            ";
                                div1.Controls.Add(createDiv);
                            }
                        }
                        conn1.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }            
        }
    }
}


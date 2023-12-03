using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class UserContext : DatabaseWrapper
    {
        public static int CekLogin(string username, string password)
        {
            string query = $"SELECT u.role_id_role FROM tim_skpi t JOIN public.\"USER\" u ON t.user_id_user = u.id_user WHERE t.username = @username  AND u.password = @password UNION SELECT u.role_id_role FROM tata_usaha tu JOIN public.\"USER\" u ON tu.user_id_user = u.id_user WHERE tu.username = @username AND u.password = @password UNION SELECT u.role_id_role FROM mahasiswa m JOIN public.\"USER\" u ON m.user_id_user = u.id_user WHERE m.username = @username AND u.password = @password;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
                new NpgsqlParameter("@password", NpgsqlDbType.Varchar){Value = password}
            };
            return commandExecutorIntValue(query, parameters);
        }
    }
}
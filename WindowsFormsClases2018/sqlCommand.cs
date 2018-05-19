using System.Data.SqlClient;

namespace WindowsFormsClases2018
{
    internal class sqlCommand
    {
        private object p;
        private SqlConnection cn;

        public sqlCommand(object p, SqlConnection cn)
        {
            this.p = p;
            this.cn = cn;
        }
    }
}
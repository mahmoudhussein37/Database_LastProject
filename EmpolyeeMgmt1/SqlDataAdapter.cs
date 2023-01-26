using System.Data;

namespace EmpolyeeMgmt1
{
    internal class SqlDataAdapter
    {
        private string query;
        private string conStr;

        public SqlDataAdapter(string query, string conStr)
        {
            this.query = query;
            this.conStr = conStr;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}
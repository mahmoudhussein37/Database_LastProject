namespace EmpolyeeMgmt1
{
    internal class SqlCommand
    {
        public SqlConnection Connection { get; internal set; }
        public string CommandText { get; internal set; }

        internal object ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}
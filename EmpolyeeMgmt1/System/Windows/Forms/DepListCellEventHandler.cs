namespace System.Windows.Forms
{
    internal class DepListCellEventHandler
    {
        private Action<object, DataGridViewCellEventArgs> depList_CellContentClick;

        public DepListCellEventHandler(Action<object, DataGridViewCellEventArgs> depList_CellContentClick)
        {
            this.depList_CellContentClick = depList_CellContentClick;
        }
    }
}
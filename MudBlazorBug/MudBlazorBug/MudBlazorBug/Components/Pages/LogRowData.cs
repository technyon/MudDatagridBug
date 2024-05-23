namespace MudDataGridBug
{
    public class LogRowData
    {
        private List<object?> data = new List<object?>();

        public LogRowData(List<object?> data) 
        {
            this.data = data;
        }

        public string GetString(int i)
        {
            string r = string.Empty;            
            try
            {
                r = Convert.ToString(data[i]);
            }
            catch 
            { 
            }

            return r;
        }

        public int GetRowIndex()
        {
            return Convert.ToInt32(data[0]);
        }
    }
}

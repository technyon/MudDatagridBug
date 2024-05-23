namespace MudDataGridBug
{
   

    public class ColumnDesciption
    {
        public string name;
        public Type? dataType;
        public bool hasData = false;

        //public static ColumnType GetTypeFromString(string typeStr)
        //{
        //    switch(typeStr.ToLower()) 
        //    {
        //        case "bigint":
        //        case "smallint":
        //        case "int":
        //            return ColumnType.Integer;
        //        case "float":
        //        case "real":
        //        case "double precision":
        //            return ColumnType.Real;
        //        case "varchar":
        //        case "text":
        //            return ColumnType.Text;
        //        case "datetime":
        //            return ColumnType.DateTime;
        //        default:
        //            return ColumnType.Unknown;  
        //    }
        //}
    }

}

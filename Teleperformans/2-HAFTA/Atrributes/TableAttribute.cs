using hafta2_1_halilsahin.Enums;

namespace hafta2_1_halilsahin.Atrributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public TableAttribute(string tableName)
        {
            TableName = tableName;
        }

        public readonly string TableName;
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(int id, ColumnDomainEnum dataType, bool required)
        {
            ColumnId = id;
            DataType = dataType;

        }

        public readonly int ColumnId;
        public readonly ColumnDomainEnum DataType;
        public bool Required;


    }
}

using System;
using System.Data.SqlClient;

namespace IK.Extensions.Sql
{
    public static class SqlDataReaderExtensions
    {
        public static T GetValue<T>(this SqlDataReader reader, string column) where T : struct
        {
            int col = reader.GetOrdinal(column);

            if (reader[column] is DBNull)
            {
                return default(T);
            }
            if (typeof(T) == typeof(DateTime))
            {
                object value = reader.GetDateTime(col);
                return (T)value;
            }
            else if (typeof(T) == typeof(byte[]))
            {
                object value = reader.GetSqlBinary(col).Value;
                return (T)value;
            }
            return (T)reader[column];
        }

        public static string GetStringValue(SqlDataReader reader, string column)
        {
            int col = reader.GetOrdinal(column);

            if (reader[column] is DBNull)
            {
                return null;
            }
            return (string)reader[column];
        }

        public static byte[] GetBytes(SqlDataReader reader, string column)
        {
            int col = reader.GetOrdinal(column);
            if (reader[column] is DBNull)
            {
                return null;
            }
            return reader.GetSqlBinary(col).Value;
        }

        public static T Field<T>(this SqlDataReader reader, string column)
        {
            try
            {
                if (reader[column] is DBNull)
                {
                    return default(T);
                }
                int col = reader.GetOrdinal(column);

                if (typeof(T) == typeof(byte[]))
                {
                    object value = reader.GetSqlBinary(col).Value;
                    return (T)value;
                }
                else if (typeof(T) == typeof(DateTime))
                {
                    object value = reader.GetDateTime(col);
                    return (T)value;
                }
                else if (typeof(T) == typeof(DateTime?))
                {
                    object value = reader.GetDateTime(col);
                    return (T)value;
                }

                return (T)reader[col];
            }
            catch (Exception) { }
            return default(T);
        }

        public static Nullable<T> GetNullOrValue<T>(this SqlDataReader reader, string column) where T : struct
        {
            int col = reader.GetOrdinal(column);

            if (reader[column] is DBNull)
            {
                return null;
            }
            if (typeof(T) == typeof(DateTime))
            {
                object value = reader.GetDateTime(col);

                return (T)value;
            }
            else if (typeof(T) == typeof(byte[]))
            {
                object value = reader.GetSqlBinary(col).Value;
                return (T)value;
            }
            return (T)reader[col];
        }
    }
}

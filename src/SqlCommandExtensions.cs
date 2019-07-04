using System;
using System.Data.SqlClient;

namespace IK.Extensions.Sql
{
    public static class SqlCommandExtensions
    {
        public static void AddParamWithValue(this SqlCommand @cmd, string param, string value)
        {
            if (String.IsNullOrEmpty(value)) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, decimal value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, decimal? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, Int32 value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, Int32? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, Int64 value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, Int64? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, Guid value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, Guid? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, bool value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, bool? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, double value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, double? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, DateTime value)
        {
            cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, DateTime? value)
        {
            if (!value.HasValue) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlCommand @cmd, string param, byte[] value)
        {
            if (value == null) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }

        /*
        public static void AddParamWithValue(this SqlCommand @cmd, string param, SqlGeometry value)
        {
            if (value == null) cmd.Parameters.AddWithValue(param, DBNull.Value);

            else
            {
                SqlParameter p = new SqlParameter();
                //p.UdtTypeName = "GEOMETRY";
                p.Value = value.STAsBinary();
                p.ParameterName = param;
                cmd.Parameters.Add(p);
            }
        }
        public static void AddParamWithValue(this SqlCommand @cmd, string param, SqlGeography value)
        {
            if (value == null) cmd.Parameters.AddWithValue(param, DBNull.Value);
            else cmd.Parameters.AddWithValue(param, value);
        }
        */
    }
}
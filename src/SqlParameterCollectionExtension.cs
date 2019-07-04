using System;
using System.Data.SqlClient;

namespace IK.Extensions.Sql
{
    public static class SqlParameterCollectionExtension
    {        public static void AddParamWithValue(this SqlParameterCollection @params, string param, string value)
        {
            if (String.IsNullOrEmpty(value)) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, decimal value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, decimal? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, Int32 value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, Int32? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, Int64 value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, Int64? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, Guid value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, Guid? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, bool value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, bool? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, double value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, double? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, DateTime value)
        {
            @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, DateTime? value)
        {
            if (!value.HasValue) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }

        public static void AddParamWithValue(this SqlParameterCollection @params, string param, byte[] value)
        {
            if (value == null) @params.AddWithValue(param, DBNull.Value);
            else @params.AddWithValue(param, value);
        }
    }
}

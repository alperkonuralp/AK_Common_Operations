using System;
using System.Numerics;

namespace AK.CommonOperations
{

    /// <summary>
    /// Converter Static Class
    /// </summary>
    public static class Converter
    {

        /// <summary>
        /// To the boolean.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Boolean? ToBoolean(object value)
        {
            if (value == null) return null;
            if (value is Boolean) return (Boolean)value;
            Boolean v;
            return Boolean.TryParse(value.ToString(), out v) ? (Boolean?)v : null;
        }

        /// <summary>
        /// To the boolean.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">if set to <c>true</c> [def].</param>
        /// <returns></returns>
        public static Boolean ToBoolean(object value, Boolean def)
        {
            if (value == null) return def;
            if (value is Boolean) return (Boolean)value;
            Boolean v;
            return Boolean.TryParse(value.ToString(), out v) ? v : def;
        }

        /// <summary>
        /// To the byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Byte? ToByte(object value)
        {
            if (value == null) return null;
            if (value is Byte) return (Byte)value;
            Byte v;
            return Byte.TryParse(value.ToString(), out v) ? (Byte?)v : null;
        }

        /// <summary>
        /// To the byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Byte ToByte(object value, Byte def)
        {
            if (value == null) return def;
            if (value is Byte) return (Byte)value;
            Byte v;
            return Byte.TryParse(value.ToString(), out v) ? v : def;
        }

        /// <summary>
        /// To the Signed byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static SByte? ToSByte(object value)
        {
            if (value == null) return null;
            if (value is SByte) return (SByte)value;
            SByte v;
            return SByte.TryParse(value.ToString(), out v) ? (SByte?)v : null;
        }

        /// <summary>
        /// To the S byte.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static SByte ToSByte(object value, SByte def)
        {
            if (value == null) return def;
            if (value is SByte) return (SByte)value;
            SByte v;
            return SByte.TryParse(value.ToString(), out v) ? v : def;
        }



        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Int16? ToInt16(object value)
        {
            if (value == null) return null;
            if (value is Int16) return (Int16)value;
            Int16 v;
            return Int16.TryParse(value.ToString(), out v) ? (Int16?)v : null;
        }
        /// <summary>
        /// To the int16.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Int16 ToInt16(object value, Int16 def)
        {
            if (value == null) return def;
            if (value is Int16) return (Int16)value;
            Int16 v;
            return Int16.TryParse(value.ToString(), out v) ? v : def;
        }


        /// <summary>
        /// To the unsigned int16.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static UInt16? ToUInt16(object value)
        {
            if (value == null) return null;
            if (value is UInt16) return (UInt16)value;
            UInt16 v;
            return UInt16.TryParse(value.ToString(), out v) ? (UInt16?)v : null;
        }

        /// <summary>
        /// To the unsigned int16.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static UInt16 ToUInt16(object value, UInt16 def)
        {
            if (value == null) return def;
            if (value is UInt16) return (UInt16)value;
            UInt16 v;
            return UInt16.TryParse(value.ToString(), out v) ? v : def;
        }

        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Int32? ToInt32(object value)
        {
            if (value == null) return null;
            if (value is Int32) return (Int32)value;
            Int32 v;
            return Int32.TryParse(value.ToString(), out v) ? (int?)v : null;
        }
        /// <summary>
        /// To the int32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Int32 ToInt32(object value, Int32 def)
        {
            if (value == null) return def;
            if (value is Int32) return (Int32)value;
            Int32 v;
            return Int32.TryParse(value.ToString(), out v) ? v : def;
        }


        /// <summary>
        /// To the unsigned int32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static UInt32? ToUInt32(object value)
        {
            if (value == null) return null;
            if (value is UInt32) return (UInt32)value;
            UInt32 v;
            return UInt32.TryParse(value.ToString(), out v) ? (UInt32?)v : null;
        }

        /// <summary>
        /// To the unsigned int32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static UInt32 ToUInt32(object value, UInt32 def)
        {
            if (value == null) return def;
            if (value is UInt32) return (UInt32)value;
            UInt32 v;
            return UInt32.TryParse(value.ToString(), out v) ? v : def;
        }

        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Int64? ToInt64(object value)
        {
            if (value == null) return null;
            if (value is Int64) return (Int64)value;
            Int64 v;
            return Int64.TryParse(value.ToString(), out v) ? (Int64?)v : null;
        }
        /// <summary>
        /// To the int64.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Int64 ToInt64(object value, Int64 def)
        {
            if (value == null) return def;
            if (value is Int64) return (Int64)value;
            Int64 v;
            return Int64.TryParse(value.ToString(), out v) ? v : def;
        }

        /// <summary>
        /// To the unsigned int64.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static UInt64? ToUInt64(object value)
        {
            if (value == null) return null;
            if (value is UInt64) return (UInt64)value;
            UInt64 v;
            return UInt64.TryParse(value.ToString(), out v) ? (UInt64?)v : null;
        }

        /// <summary>
        /// To the unsigned int64.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static UInt64 ToUInt64(object value, UInt64 def)
        {
            if (value == null) return def;
            if (value is UInt64) return (UInt64)value;
            UInt64 v;
            return UInt64.TryParse(value.ToString(), out v) ? v : def;
        }




        /// <summary>
        /// To the single.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Single? ToSingle(object value)
        {
            if (value == null) return null;
            if (value is Single) return (Single)value;
            Single v;
            return Single.TryParse(value.ToString(), out v) ? (Single?)v : null;
        }

        /// <summary>
        /// To the single.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Single ToSingle(object value, Single def)
        {
            if (value == null) return def;
            if (value is Single) return (Single)value;
            Single v;
            return Single.TryParse(value.ToString(), out v) ? v : def;
        }



        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Double? ToDouble(object value)
        {
            if (value == null) return null;
            if (value is Double) return (Double)value;
            Double v;
            return Double.TryParse(value.ToString(), out v) ? (Double?)v : null;
        }

        /// <summary>
        /// To the double.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Double ToDouble(object value, Double def)
        {
            if (value == null) return def;
            if (value is Double) return (Double)value;
            Double v;
            return Double.TryParse(value.ToString(), out v) ? v : def;
        }



        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Decimal? ToDecimal(object value)
        {
            if (value == null) return null;
            if (value is Decimal) return (Decimal)value;
            Decimal v;
            return Decimal.TryParse(value.ToString(), out v) ? (Decimal?)v : null;
        }

        /// <summary>
        /// To the decimal.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Decimal ToDecimal(object value, Decimal def)
        {
            if (value == null) return def;
            if (value is Decimal) return (Decimal)value;
            Decimal v;
            return Decimal.TryParse(value.ToString(), out v) ? v : def;
        }



        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Guid? ToGuid(object value)
        {
            if (value == null) return null;
            if (value is Guid) return (Guid)value;
            Guid v;
            return Guid.TryParse(value.ToString(), out v) ? (Guid?)v : null;
        }

        /// <summary>
        /// To the GUID.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static Guid ToGuid(object value, Guid def)
        {
            if (value == null) return def;
            if (value is Guid) return (Guid)value;
            Guid v;
            return Guid.TryParse(value.ToString(), out v) ? v : def;
        }



        /// <summary>
        /// To the date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(object value)
        {
            if (value == null) return null;
            if (value is DateTime) return (DateTime)value;
            DateTime v;
            return DateTime.TryParse(value.ToString(), out v) ? (DateTime?)v : null;
        }

        /// <summary>
        /// To the date time.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static DateTime ToDateTime(object value, DateTime def)
        {
            if (value == null) return def;
            if (value is DateTime) return (DateTime)value;
            DateTime v;
            return DateTime.TryParse(value.ToString(), out v) ? v : def;
        }


        /// <summary>
        /// To the time span.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static TimeSpan? ToTimeSpan(object value)
        {
            if (value == null) return null;
            if (value is TimeSpan) return (TimeSpan)value;
            TimeSpan v;
            return TimeSpan.TryParse(value.ToString(), out v) ? (TimeSpan?)v : null;
        }

        /// <summary>
        /// To the time span.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(object value, TimeSpan def)
        {
            if (value == null) return def;
            if (value is TimeSpan) return (TimeSpan)value;
            TimeSpan v;
            return TimeSpan.TryParse(value.ToString(), out v) ? v : def;
        }


        /// <summary>
        /// To the big integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static BigInteger? ToBigInteger(object value)
        {
            if (value == null) return null;
            if (value is BigInteger) return (BigInteger)value;
            BigInteger v;
            return BigInteger.TryParse(value.ToString(), out v) ? (BigInteger?)v : null;
        }

        /// <summary>
        /// To the big integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="def">The def.</param>
        /// <returns></returns>
        public static BigInteger ToBigInteger(object value, BigInteger def)
        {
            if (value == null) return def;
            if (value is BigInteger) return (BigInteger)value;
            BigInteger v;
            return BigInteger.TryParse(value.ToString(), out v) ? v : def;
        }


    }
}

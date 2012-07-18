using AK.CommonOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

namespace AK.CommonOperations.Test
{


    /// <summary>
    ///This is a test class for ConverterTest and is intended
    ///to contain all ConverterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConverterTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ToBigInteger
        ///</summary>
        [TestMethod()]
        public void ToBigInteger1Test()
        {
            object value = "100"; // TODO: Initialize to an appropriate value
            BigInteger? expected = 100; // TODO: Initialize to an appropriate value
            var actual = Converter.ToBigInteger(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the big integer null test.
        /// </summary>
        [TestMethod()]
        public void ToBigInteger1NullTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            BigInteger? expected = null; // TODO: Initialize to an appropriate value
            var actual = Converter.ToBigInteger(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the big integer null test2.
        /// </summary>
        [TestMethod()]
        public void ToBigInteger1NullTest2()
        {
            object value = "abc"; // TODO: Initialize to an appropriate value
            BigInteger? expected = null; // TODO: Initialize to an appropriate value
            BigInteger? actual = Converter.ToBigInteger(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBigInteger
        ///</summary>
        [TestMethod()]
        public void ToBigInteger2Test()
        {
            object value = "1521478965"; // TODO: Initialize to an appropriate value
            BigInteger def = 0; // TODO: Initialize to an appropriate value
            BigInteger expected = 1521478965; // TODO: Initialize to an appropriate value
            BigInteger actual = Converter.ToBigInteger(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the big integer2 null test.
        /// </summary>
        [TestMethod()]
        public void ToBigInteger2NullTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            BigInteger def = 0; // TODO: Initialize to an appropriate value
            BigInteger expected = 0; // TODO: Initialize to an appropriate value
            BigInteger actual = Converter.ToBigInteger(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the big integer2 null test2.
        /// </summary>
        [TestMethod()]
        public void ToBigInteger2NullTest2()
        {
            object value = "abc"; // TODO: Initialize to an appropriate value
            BigInteger def = 0; // TODO: Initialize to an appropriate value
            BigInteger expected = 0; // TODO: Initialize to an appropriate value
            BigInteger actual = Converter.ToBigInteger(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBoolean
        ///</summary>
        [TestMethod()]
        public void ToBoolean1Test()
        {
            object value = "true"; // TODO: Initialize to an appropriate value
            bool? expected = true; // TODO: Initialize to an appropriate value
            bool? actual = Converter.ToBoolean(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the boolean1 test2.
        /// </summary>
        [TestMethod()]
        public void ToBoolean1Test2()
        {
            object value = "false"; // TODO: Initialize to an appropriate value
            bool? expected = false; // TODO: Initialize to an appropriate value
            bool? actual = Converter.ToBoolean(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the boolean1 test2.
        /// </summary>
        [TestMethod()]
        public void ToBoolean1NullTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            bool? expected = null; // TODO: Initialize to an appropriate value
            bool? actual = Converter.ToBoolean(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToBoolean1NullTest2()
        {
            object value = 123; // TODO: Initialize to an appropriate value
            bool? expected = null; // TODO: Initialize to an appropriate value
            bool? actual = Converter.ToBoolean(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToBoolean
        ///</summary>
        [TestMethod()]
        public void ToBoolean2Test()
        {
            object value = "true"; // TODO: Initialize to an appropriate value
            bool def = false; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual = Converter.ToBoolean(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the boolean2 test2.
        /// </summary>
        [TestMethod()]
        public void ToBoolean2Test2()
        {
            object value = "false"; // TODO: Initialize to an appropriate value
            bool def = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual = Converter.ToBoolean(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the boolean2 null test.
        /// </summary>
        [TestMethod()]
        public void ToBoolean2NullTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            bool def = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual = Converter.ToBoolean(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Toes the boolean2 null test.
        /// </summary>
        [TestMethod()]
        public void ToBoolean2NullTest2()
        {
            object value = 321; // TODO: Initialize to an appropriate value
            bool def = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual = Converter.ToBoolean(value, def);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToByte
        ///</summary>
        [TestMethod()]
        public void ToByteTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<byte> expected = new Nullable<byte>(); // TODO: Initialize to an appropriate value
            Nullable<byte> actual;
            actual = Converter.ToByte(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToByte
        ///</summary>
        [TestMethod()]
        public void ToByteTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            byte def = 0; // TODO: Initialize to an appropriate value
            byte expected = 0; // TODO: Initialize to an appropriate value
            byte actual;
            actual = Converter.ToByte(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDateTime
        ///</summary>
        [TestMethod()]
        public void ToDateTimeTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<DateTime> expected = new Nullable<DateTime>(); // TODO: Initialize to an appropriate value
            Nullable<DateTime> actual;
            actual = Converter.ToDateTime(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDateTime
        ///</summary>
        [TestMethod()]
        public void ToDateTimeTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            DateTime def = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            actual = Converter.ToDateTime(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDecimal
        ///</summary>
        [TestMethod()]
        public void ToDecimalTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<Decimal> expected = new Nullable<Decimal>(); // TODO: Initialize to an appropriate value
            Nullable<Decimal> actual;
            actual = Converter.ToDecimal(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDecimal
        ///</summary>
        [TestMethod()]
        public void ToDecimalTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Decimal def = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            actual = Converter.ToDecimal(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDouble
        ///</summary>
        [TestMethod()]
        public void ToDoubleTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            double def = 0F; // TODO: Initialize to an appropriate value
            double expected = 0F; // TODO: Initialize to an appropriate value
            double actual;
            actual = Converter.ToDouble(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToDouble
        ///</summary>
        [TestMethod()]
        public void ToDoubleTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<double> expected = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> actual;
            actual = Converter.ToDouble(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToGuid
        ///</summary>
        [TestMethod()]
        public void ToGuidTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Guid def = new Guid(); // TODO: Initialize to an appropriate value
            Guid expected = new Guid(); // TODO: Initialize to an appropriate value
            Guid actual;
            actual = Converter.ToGuid(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToGuid
        ///</summary>
        [TestMethod()]
        public void ToGuidTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<Guid> expected = new Nullable<Guid>(); // TODO: Initialize to an appropriate value
            Nullable<Guid> actual;
            actual = Converter.ToGuid(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt16
        ///</summary>
        [TestMethod()]
        public void ToInt16Test()
        {
            object value = null; // TODO: Initialize to an appropriate value
            short def = 0; // TODO: Initialize to an appropriate value
            short expected = 0; // TODO: Initialize to an appropriate value
            short actual;
            actual = Converter.ToInt16(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt16
        ///</summary>
        [TestMethod()]
        public void ToInt16Test1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<short> expected = new Nullable<short>(); // TODO: Initialize to an appropriate value
            Nullable<short> actual;
            actual = Converter.ToInt16(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt32
        ///</summary>
        [TestMethod()]
        public void ToInt32Test()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<int> expected = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> actual;
            actual = Converter.ToInt32(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt32
        ///</summary>
        [TestMethod()]
        public void ToInt32Test1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            int def = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = Converter.ToInt32(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt64
        ///</summary>
        [TestMethod()]
        public void ToInt64Test()
        {
            object value = null; // TODO: Initialize to an appropriate value
            long def = 0; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = Converter.ToInt64(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToInt64
        ///</summary>
        [TestMethod()]
        public void ToInt64Test1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<long> expected = new Nullable<long>(); // TODO: Initialize to an appropriate value
            Nullable<long> actual;
            actual = Converter.ToInt64(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSByte
        ///</summary>
        [TestMethod()]
        public void ToSByteTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            sbyte def = 0; // TODO: Initialize to an appropriate value
            sbyte expected = 0; // TODO: Initialize to an appropriate value
            sbyte actual;
            actual = Converter.ToSByte(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSByte
        ///</summary>
        [TestMethod()]
        public void ToSByteTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<sbyte> expected = new Nullable<sbyte>(); // TODO: Initialize to an appropriate value
            Nullable<sbyte> actual;
            actual = Converter.ToSByte(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSingle
        ///</summary>
        [TestMethod()]
        public void ToSingleTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<float> expected = new Nullable<float>(); // TODO: Initialize to an appropriate value
            Nullable<float> actual;
            actual = Converter.ToSingle(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToSingle
        ///</summary>
        [TestMethod()]
        public void ToSingleTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            float def = 0F; // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = Converter.ToSingle(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToTimeSpan
        ///</summary>
        [TestMethod()]
        public void ToTimeSpanTest()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<TimeSpan> expected = new Nullable<TimeSpan>(); // TODO: Initialize to an appropriate value
            Nullable<TimeSpan> actual;
            actual = Converter.ToTimeSpan(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToTimeSpan
        ///</summary>
        [TestMethod()]
        public void ToTimeSpanTest1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            TimeSpan def = new TimeSpan(); // TODO: Initialize to an appropriate value
            TimeSpan expected = new TimeSpan(); // TODO: Initialize to an appropriate value
            TimeSpan actual;
            actual = Converter.ToTimeSpan(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUInt16
        ///</summary>
        [TestMethod()]
        public void ToUInt16Test()
        {
            object value = null; // TODO: Initialize to an appropriate value
            ushort def = 0; // TODO: Initialize to an appropriate value
            ushort expected = 0; // TODO: Initialize to an appropriate value
            ushort actual;
            actual = Converter.ToUInt16(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUInt16
        ///</summary>
        [TestMethod()]
        public void ToUInt16Test1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<ushort> expected = new Nullable<ushort>(); // TODO: Initialize to an appropriate value
            Nullable<ushort> actual;
            actual = Converter.ToUInt16(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUInt32
        ///</summary>
        [TestMethod()]
        public void ToUInt32Test()
        {
            object value = null; // TODO: Initialize to an appropriate value
            uint def = 0; // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            actual = Converter.ToUInt32(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUInt32
        ///</summary>
        [TestMethod()]
        public void ToUInt32Test1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<uint> expected = new Nullable<uint>(); // TODO: Initialize to an appropriate value
            Nullable<uint> actual;
            actual = Converter.ToUInt32(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUInt64
        ///</summary>
        [TestMethod()]
        public void ToUInt64Test()
        {
            object value = null; // TODO: Initialize to an appropriate value
            ulong def = 0; // TODO: Initialize to an appropriate value
            ulong expected = 0; // TODO: Initialize to an appropriate value
            ulong actual;
            actual = Converter.ToUInt64(value, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToUInt64
        ///</summary>
        [TestMethod()]
        public void ToUInt64Test1()
        {
            object value = null; // TODO: Initialize to an appropriate value
            Nullable<ulong> expected = new Nullable<ulong>(); // TODO: Initialize to an appropriate value
            Nullable<ulong> actual;
            actual = Converter.ToUInt64(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

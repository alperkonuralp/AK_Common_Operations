using System.Diagnostics;
using AK.CommonOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AK.CommonOperations.Test
{


    /// <summary>
    ///This is a test class for JsonNetSerializerHelperTest and is intended
    ///to contain all JsonNetSerializerHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class JsonNetSerializerHelperTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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
        ///A test for Serialize
        ///</summary>
        [TestMethod()]
        public void SerializeTest()
        {
            object obj = new TestType()
            {
                Id = 1,
                Name = "Deneme 1",
                NullProperty = null,
                DateTimeProperty = new DateTime(2012, 7, 26, 13, 21, 36, 0),
                GuidProperty = new Guid("38fa9452-4491-4a96-a48b-be0854f10286")
            };
            //string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual = JsonNetSerializerHelper.Serialize(obj);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual, JsonString);
            Debug.Write(actual);
        }

        const string JsonString = @"{""Id"":1,""Name"":""Deneme 1"",""NullProperty"":null,""DateTimeProperty"":""2012-07-26T13:21:36"",""GuidProperty"":""38fa9452-4491-4a96-a48b-be0854f10286""}";

        [TestMethod()]
        public void DeserializeTest()
        {
            //DeserializeTestHelper<GenericParameterHelper>();
            //TestType expected = default(T); // TODO: Initialize to an appropriate value
            var expected = new TestType()
                               {
                                   Id = 1,
                                   Name = "Deneme 1",
                                   NullProperty = null,
                                   DateTimeProperty = new DateTime(2012, 7, 26, 13, 21, 36),
                                   GuidProperty = new Guid("38fa9452-4491-4a96-a48b-be0854f10286")
                               };
            var actual = JsonNetSerializerHelper.Deserialize<TestType>(JsonString);

            Assert.IsNotNull(actual);
            Assert.AreEqual(actual, expected);
        }
    }
}

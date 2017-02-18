using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace SingletonTest
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void Configuration_GetValue_WithNotExistingKey_ReturnsNull()
        {
            // arrange
            string keyName = "aKey";
            string value;

            // act
            value = Singleton.Configuration.getInstance().getValue(keyName);

            // assert
            Assert.AreEqual(null, value, "Not existing key should have null value");
        }

        [TestMethod]
        public void Configuration_GetValue_WithtExistingKey_ReturnsValue()
        {
            // arrange
            string keyName = "aKey";
            string value = "42";
            Singleton.Configuration.getInstance().setValue(keyName, value);
            string valueFromConfig;

            // act
            valueFromConfig = Singleton.Configuration.getInstance().getValue(keyName);

            // assert
            Assert.AreEqual(value, valueFromConfig, "The key didn't return the expected value");
        }

        [TestMethod]
        public void Configuration_SetValue_WithtExistingKey_UpdatesValue()
        {
            // arrange
            string keyName = "aKey";
            string valueOld = "42";
            string valueNew = "21";
            Singleton.Configuration.getInstance().setValue(keyName, valueOld);
            string valueFromConfig;

            // act
            Singleton.Configuration.getInstance().setValue(keyName, valueNew);
            valueFromConfig = Singleton.Configuration.getInstance().getValue(keyName);

            // assert
            Assert.AreEqual(valueNew, valueFromConfig, "Value had not been updated");
        }

        [TestMethod]
        public void Configuration_SetValue_WithtNotExistingKey_InsertsNewValue()
        {
            // arrange
            string keyName = "aKey";
            string value = "42";
            string valueFromConfig;

            // act
            Singleton.Configuration.getInstance().setValue(keyName, value);
            valueFromConfig = Singleton.Configuration.getInstance().getValue(keyName);

            // assert
            Assert.AreEqual(value, valueFromConfig, "Value had not been updated");
        }
    }
}

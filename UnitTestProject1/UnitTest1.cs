using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name_4_ReturnsFalse() //меньше 4
        {
            string name = "ab";
            bool result = IsNameValid(name);
            Assert.IsFalse(result);
        }


        public void Name_50_ReturnsFalse() //больше 50
        {
            string name = "abcdefghijklmnop";
            bool result = IsNameValid(name);
            Assert.IsFalse(result);
        }


        public void Name_4And50_ReturnsTrue() // от 4 до 50
        {
            string name1 = "abc";
            string name2 = "abcdefghijklmno";

            bool result1 = IsNameValid(name1);
            bool result2 = IsNameValid(name2);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        private bool IsNameValid(string name)
        {
            if (name.Length < 3 || name.Length > 15) // Проверяем, что длина имени находится в диапазоне от 3 до 15 символов
            {
                return false;
            }
            return true;
        }



        [TestMethod]
        public void Name_WithLessThan10_ReturnsFalse() //меньше 10
        {
            string name = "ab";
            bool result = IsNameValid2(name);
            Assert.IsFalse(result);
        }


        public void Name_WithMoreThan35_ReturnsFalse() //больше 35
        {
            string name = "abcdefghijklmnop";
            bool result = IsNameValid2(name);
            Assert.IsFalse(result);
        }


        public void Name_10And35_ReturnsTrue() // от 10 до 35
        {
            string name1 = "abc";
            string name2 = "abcdefghijklmno";

            bool result1 = IsNameValid2(name1);
            bool result2 = IsNameValid2(name2);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        private bool IsNameValid2(string name)
        {
            if (name.Length < 10 || name.Length > 35) // Проверяем, что длина имени находится в диапазоне от 3 до 15 символов
            {
                return false;
            }
            return true;
        }
    }
}

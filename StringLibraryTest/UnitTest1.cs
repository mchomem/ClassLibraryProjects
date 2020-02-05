using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            String[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };

            foreach (var word in words)
            {
                Boolean result = word.StartsWithUpper();
                Assert.IsTrue(result, String.Format("Expected for '{0}': true; Actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            String[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство", "1234", ".", ";", " " };

            foreach (var word in words)
            {
                Boolean result = word.StartsWithUpper();
                Assert.IsFalse(result, String.Format("Expected for '{0}': false; Actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            String[] words = { string.Empty, null };

            foreach (var word in words)
            {
                Boolean result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result, String.Format("Expected for '{0}': false; Actual: {1}", word == null ? "<null>" : word, result));
            }
        }
    }
}
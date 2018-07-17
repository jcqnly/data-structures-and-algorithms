using HashTables;
using System;
using Xunit;

namespace HashTableTests
{
    public class TestHashTables
    {
        [Fact]
        public void CanInsertValue()
        {
            //arrange
            HashTable ht = new HashTable();

            //act
            ht.Add("bear", 50);
            ht.Add("act", 5);
            ht.Add("dog", 1);
            ht.Add("pig", 30);
            ht.Add("ball", 75);
            ht.Add("rat", 23);
            ht.Add("man", 99);

            int findValue = ht.Find("bear");

            //assert
            Assert.Equal(50, findValue);
        }

        [Fact]
        public void CanCheckIfContainsCanFindKey()
        {
            //arrange
            HashTable ht = new HashTable();

            //act
            ht.Add("bear", 50);
            ht.Add("act", 5);
            ht.Add("dog", 1);
            ht.Add("pig", 30);
            ht.Add("ball", 75);
            ht.Add("rat", 23);
            ht.Add("man", 99);

            int findValue = ht.Find("bear");

            //assert
            Assert.True(ht.Contains("ball"));
        }

        [Fact]
        public void HashTableCanHandleCollision1()
        {
            //arrange
            HashTable ht = new HashTable();

            //act
            ht.Add("cat", 50);
            ht.Add("act", 5);
            ht.Add("tac", 1);
            ht.Add("rat", 23);
            ht.Add("man", 99);

            int findValue = ht.Find("cat");

            //assert
            Assert.Equal(50, findValue);
        }

        [Fact]
        public void HashTableCanHandleCollision2()
        {
            //arrange
            HashTable ht = new HashTable();

            //act
            ht.Add("dog", 30);
            ht.Add("god", 15);
            ht.Add("dog", 10);
            ht.Add("rat", 23);
            ht.Add("man", 99);

            int findValue = ht.Find("dog");

            //assert
            Assert.Equal(10, findValue);
        }
    }
}

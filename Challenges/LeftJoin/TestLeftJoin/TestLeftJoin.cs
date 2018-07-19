using LeftJoin;
using Xunit;

namespace TestLeftJoin
{
    public class TestLeftJoin
    {
        [Theory]
        [InlineData("anger", "delight")]
        [InlineData("cloudy", "rainy")]
        [InlineData("rug", "mug")]
        public void CanJoinLeftTable(string value1, string value2)
        {
            //arrange
            //instantiate new Hashtable ht1 and add contents
            HashTable ht1 = new HashTable();
            ht1.Add("furniture", "chair");
            ht1.Add("wrath", value1);
            ht1.Add("diligent", "employed");
            ht1.Add("outfit", "garb");
            ht1.Add("guide", "usher");

            //instantiate new Hashtable ht2 and add contents
            HashTable ht2 = new HashTable();
            ht2.Add("furniture", "table");
            ht2.Add("wrath", value2);
            ht2.Add("sun", "idle");
            ht2.Add("guide", "follow");
            ht2.Add("flow", "jam");

            //act
            HashTable ht3 = ht1.LeftJoinHashTable(ht1, ht2);
            int hashValue = ht1.GetHash("wrath");

            //assert
            Assert.Equal(ht3.Find("wrath"), value2);
        }

        [Theory]
        [InlineData("anger", "delight")]
        [InlineData("cloudy", "rainy")]
        [InlineData("rug", "mug")]
        public void CanJoinLeftTableANDOutputNodesAtSameKey(string value1, string value2)
        {
            //arrange
            //instantiate new Hashtable ht1 and add contents
            HashTable ht1 = new HashTable();
            ht1.Add("furniture", "chair");
            ht1.Add("wrath", value1);
            ht1.Add("diligent", "employed");
            ht1.Add("outfit", "garb");
            ht1.Add("guide", "usher");

            //instantiate new Hashtable ht2 and add contents
            HashTable ht2 = new HashTable();
            ht2.Add("furniture", "table");
            ht2.Add("wrath", value2);
            ht2.Add("sun", "idle");
            ht2.Add("guide", "follow");
            ht2.Add("flow", "jam");

            //act
            HashTable ht3 = ht1.LeftJoinHashTable(ht1, ht2);
            int hashValue = ht1.GetHash("wrath");

            //assert
            Assert.Equal(ht3.HashArray[hashValue].Next.Value, value1);
        }
    }
}
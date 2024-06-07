using Xunit;

namespace Atividade09.Tests
{

    public class ItemCollectionTests
    {
        [Fact]
        public void AddItem_Should_Add_Item_To_Collection()
        {
            // Arrange
            var collection = new ItemCollection();
            var item = new Item("Sample Item");

            // Act
            collection.AddItem(item);

            // Assert
            Assert.Contains(item, collection.GetItems());
        }

        [Fact]
        public void AddItem_Should_Throw_Exception_If_Item_Is_Null()
        {
            // Arrange
            var collection = new ItemCollection();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => collection.AddItem(null));
        }

        [Fact]
        public void RemoveItem_Should_Remove_Item_From_Collection()
        {
            // Arrange
            var collection = new ItemCollection();
            var item = new Item("Sample Item");
            collection.AddItem(item);

            // Act
            collection.RemoveItem(item);

            // Assert
            Assert.Equal(false, collection.GetItems().Contains(item));
        }

        [Fact]
        public void RemoveItem_Should_Throw_Exception_If_Item_Not_Found()
        {
            // Arrange
            var collection = new ItemCollection();
            var item = new Item("Sample Item");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => collection.RemoveItem(item));
        }

        [Fact]
        public void GetItems_Should_Return_All_Items()
        {
            // Arrange
            var collection = new ItemCollection();
            var item1 = new Item("Item 1");
            var item2 = new Item("Item 2");
            collection.AddItem(item1);
            collection.AddItem(item2);

            // Act
            var items = collection.GetItems();

            // Assert
            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
        }
    }
}

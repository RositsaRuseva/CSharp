using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        //private Item item;
        //private BankVault bankVault;
        [SetUp]
        public void Setup()
        {
            var item = new Item("TestOwner", "Test0");
            var item1 = new Item("TestOwner1", "Test1");
            var item2 = new Item("TestOwner2", "Test2");
            var item3 = new Item("TestOwner3", "Test3");

            BankVault bankVault = new BankVault();
            bankVault.AddItem("A1", item1);
            bankVault.AddItem("A2", item2);
        }

        [Test]
        public void IsTheItemOwnerNameCorrect()
        {
            var item = new Item("TestOwner", "Test0");
            Assert.AreEqual("TestOwner", item.Owner);
        }
        [Test]
        public void IsTheItemIdCorrect()
        {
            var item = new Item("TestOwner", "Test0");
            Assert.AreEqual("Test0", item.ItemId);
        }
        [Test]
        public void AreVaultCellsNotNull()
        {
            BankVault bankVault = new BankVault();
            Assert.IsNotNull(bankVault.VaultCells.Count);
        }
        [Test]
        //if the item doesnt exist;
        public void AddItemIfNotContainKeyException()
        {
            Item test = new Item("TestOwner3", "Test3");
            BankVault bankVault = new BankVault();
            Assert.That(() => bankVault.AddItem("NotExisting", test), Throws.ArgumentException);
        }
        [Test]
        //row40
        public void AddItemIfCellIsNotEmpty()
        {
            Item test = new Item("TestOwner3", "Test3");
            Item test2 = new Item("TestOwner3", "Test3");
            BankVault bankVault = new BankVault();
            bankVault.AddItem("A1", test);
            Assert.That(() => bankVault.AddItem("A1", test2), Throws.ArgumentException);
        }
        [Test]
        public void AddSameItem()
        {
            Item test = new Item("TestOwner3", "Test3");
            BankVault bankVault = new BankVault();
            bankVault.AddItem("C1", test);
            Assert.That(() => bankVault.AddItem("C2", test), Throws.InvalidOperationException);
        }
        [Test]
        public void AddItemReturnsStringMessage()
        {

            BankVault bankVault = new BankVault();
            Item test = new Item("TestOwner", "Test0");
            string actualResult = bankVault.AddItem("A1", test);
            string expectedResult = $"Item:{test.ItemId} saved successfully!";
            //Assert.AreEqual($"Item:{test.ItemId} saved successfully!", bankVault.AddItem("A1", test));
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void RemoveItemWithNoExistingCell()
        {
            BankVault bankVault = new BankVault();
            Item test = new Item("Owner", "Test0");
            Assert.That(() => bankVault.RemoveItem("Test", test), Throws.ArgumentException);
        }
        [Test]
        public void RemoveItemCellExistButItsEmpty()
        {
            BankVault bankVault = new BankVault();
            Item test = new Item("Owner", "Test0");
            Assert.That(() => bankVault.RemoveItem("A1", test), Throws.ArgumentException);
        }
        [Test]
        public void RemoveItemReturnString()
        {
            BankVault bankVault = new BankVault();
            Item test = new Item("Owner", "Test0");
            bankVault.AddItem("A1", test);
            Assert.AreEqual($"Remove item:{test.ItemId} successfully!", bankVault.RemoveItem("A1", test));
        }

    }
}

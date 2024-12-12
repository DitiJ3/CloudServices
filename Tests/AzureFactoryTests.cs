using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudServices.Azure;
using CloudServices.Core;

namespace CloudServices.Tests
{
    /// <summary>
    /// Test class for the AzureFactory, ensuring it creates correct service instances.
    /// </summary>
    [TestClass]
    public class AzureFactoryTests
    {
        private AzureFactory _factory;

        /// <summary>
        /// Initializes a new instance of AzureFactory before each test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _factory = new AzureFactory(); // Arrange: Setting up the factory instance
        }

        /// <summary>
        /// Tests if AzureFactory creates an instance of AzureVirtualMachine.
        /// </summary>
        [TestMethod]
        public void AzureFactory_ShouldCreateVirtualMachine()
        {
            // Act: Create a virtual machine using the factory
            var vm = _factory.CreateVirtualMachine();

            // Assert: Verify the result
            Assert.IsNotNull(vm, "The created virtual machine should not be null.");
            Assert.IsInstanceOfType(vm, typeof(AzureVirtualMachine), "The created object should be of type AzureVirtualMachine.");
            Assert.AreEqual("Azure Virtual Machine Details: ev5, us-east-a, Is Running: False", vm.GetDetails(), "The virtual machine details should match the expected output.");
        }

        /// <summary>
        /// Tests if AzureFactory creates an instance of AzureDatabaseService.
        /// </summary>
        [TestMethod]
        public void AzureFactory_ShouldCreateDatabaseService()
        {
            // Act: Create a database service using the factory
            var db = _factory.CreateDatabaseService();

            // Assert: Verify the result
            Assert.IsNotNull(db, "The created database service should not be null.");
            Assert.IsInstanceOfType(db, typeof(AzureDatabaseService), "The created object should be of type AzureDatabaseService.");
            Assert.AreEqual("Azure Database Details: Engine Postgress, 10 GB, Encrypted: True, Running: False", db.GetDetails(), "The database details should match the expected output.");
        }

        /// <summary>
        /// Tests if AzureFactory creates an instance of AzureStorageService.
        /// </summary>
        [TestMethod]
        public void AzureFactory_ShouldCreateStorageService()
        {
            // Act: Create a storage service using the factory
            var storage = _factory.CreateStorageService();

            // Assert: Verify the result
            Assert.IsNotNull(storage, "The created storage service should not be null.");
            Assert.IsInstanceOfType(storage, typeof(AzureStorageService), "The created object should be of type AzureStorageService.");
            Assert.AreEqual("Azure Storage Details: SSD, 50 GB, Encrypted: True", storage.GetDetails(), "The storage service details should match the expected output.");
        }

        /// <summary>
        /// Tests if AzureFactory creates an instance of AzureVNet.
        /// </summary>
        [TestMethod]
        public void AzureFactory_ShouldCreateVNet()
        {
            // Act: Create a virtual private network using the factory
            var vpc = _factory.CreateVNet();

            // Assert: Verify the result
            Assert.IsNotNull(vpc, "The created VNet should not be null.");
            Assert.IsInstanceOfType(vpc, typeof(AzureVnet), "The created object should be of type AzureVnet.");
            Assert.AreEqual("Azure Vnet Details: MyVnet, CIDR Block: 10.0.0.0/16, Configured: False", vpc.GetDetails(), "The VNet details should match the expected output.");
        }

        /// <summary>
        /// Tests if AzureFactory creates an instance of AzureSubnet.
        /// </summary>
        [TestMethod]
        public void AzureFactory_ShouldCreateSubnet()
        {
            // Act: Create a subnet using the factory
            var subnet = _factory.CreateSubnet();

            // Assert: Verify the result
            Assert.IsNotNull(subnet, "The created subnet should not be null.");
            Assert.IsInstanceOfType(subnet, typeof(AzureSubnet), "The created object should be of type AzureSubnet.");
            Assert.AreEqual("Azure Subnet Details: MySubnet, CIDR Block: 10.0.1.0/24, Configured: False", subnet.GetDetails(), "The subnet details should match the expected output.");
        }
    }
}

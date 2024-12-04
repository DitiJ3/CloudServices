using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudServices.GCP;
using CloudServices.Core;

namespace CloudServices.Tests
{
    /// <summary>
    /// Test class for the GCPFactory, ensuring it creates correct service instances.
    /// </summary>
    [TestClass]
    public class GCPFactoryTests
    {
        private GCPFactory _factory;

        /// <summary>
        /// Initializes a new instance of GCPFactory before each test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _factory = new GCPFactory(); // Arrange: Setting up the factory instance
        }

        /// <summary>
        /// Tests if GCPFactory creates an instance of GCPVirtualMachine.
        /// </summary>
        [TestMethod]
        public void GCPFactory_ShouldCreateVirtualMachine()
        {
            // Act: Create a virtual machine using the factory
            var vm = _factory.CreateVirtualMachine();

            // Assert: Verify the result
            Assert.IsNotNull(vm, "The created virtual machine should not be null.");
            Assert.IsInstanceOfType(vm, typeof(GCPVirtualMachine), "The created object should be of type GCPVirtualMachine.");
            Assert.AreEqual("GCP Virtual Machine Details: t2.micro, us-east-1, Is Running: False", vm.GetDetails(), "The virtual machine details should match the expected output.");
        }

        /// <summary>
        /// Tests if GCPFactory creates an instance of GCPDatabaseService.
        /// </summary>
        [TestMethod]
        public void GCPFactory_ShouldCreateDatabaseService()
        {
            // Act: Create a database service using the factory
            var db = _factory.CreateDatabaseService();

            // Assert: Verify the result
            Assert.IsNotNull(db, "The created database service should not be null.");
            Assert.IsInstanceOfType(db, typeof(GCPDatabaseService), "The created object should be of type GCPDatabaseService.");
            Assert.AreEqual("GCP Database Details: Engine MySQL, 10 GB, Encrypted: True, Running: False", db.GetDetails(), "The database details should match the expected output.");
        }

        /// <summary>
        /// Tests if GCPFactory creates an instance of GCPStorageService.
        /// </summary>
        [TestMethod]
        public void GCPFactory_ShouldCreateStorageService()
        {
            // Act: Create a storage service using the factory
            var storage = _factory.CreateStorageService();

            // Assert: Verify the result
            Assert.IsNotNull(storage, "The created storage service should not be null.");
            Assert.IsInstanceOfType(storage, typeof(GCPStorageService), "The created object should be of type GCPStorageService.");
            Assert.AreEqual("GCP Storage Details: SSD, 50 GB, Encrypted: True", storage.GetDetails(), "The storage service details should match the expected output.");
        }

        /// <summary>
        /// Tests if GCPFactory creates an instance of GCPVNet.
        /// </summary>
        [TestMethod]
        public void GCPFactory_ShouldCreateVNet()
        {
            // Act: Create a virtual network using the factory
            var vnet = _factory.CreateVNet();

            // Assert: Verify the result
            Assert.IsNotNull(vnet, "The created VNet should not be null.");
            Assert.IsInstanceOfType(vnet, typeof(GCPVnet), "The created object should be of type GCPVnet.");
            Assert.AreEqual("GCP Vnet Details: MyVnet, CIDR Block: 10.0.0.0/16, Configured: False", vnet.GetDetails(), "The VNet details should match the expected output.");
        }

        /// <summary>
        /// Tests if GCPFactory creates an instance of GCPSubnet.
        /// </summary>
        [TestMethod]
        public void GCPFactory_ShouldCreateSubnet()
        {
            // Act: Create a subnet using the factory
            var subnet = _factory.CreateSubnet();

            // Assert: Verify the result
            Assert.IsNotNull(subnet, "The created subnet should not be null.");
            Assert.IsInstanceOfType(subnet, typeof(GCPSubnet), "The created object should be of type GCPSubnet.");
            Assert.AreEqual("GCP Subnet Details: MySubnet, CIDR Block: 10.0.1.0/24, Configured: False", subnet.GetDetails(), "The subnet details should match the expected output.");
        }
    }
}

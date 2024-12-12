using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudServices.AWS;
using CloudServices.Core;

namespace CloudServices.Tests
{
    /// <summary>
    /// Test class for the AWSFactory, ensuring it creates correct service instances.
    /// </summary>
    [TestClass]
    public class AWSFactoryTests
    {
        private AWSFactory _factory;

        /// <summary>
        /// Initializes a new instance of AWSFactory before each test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _factory = new AWSFactory(); // Arrange: Setting up the factory instance
        }

        /// <summary>
        /// Tests if AWSFactory creates an instance of AWSVirtualMachine.
        /// </summary>
        [TestMethod]
        public void AWSFactory_ShouldCreateVirtualMachine()
        {
            // Act: Create a virtual machine using the factory
            var vm = _factory.CreateVirtualMachine();

            // Assert: Verify the result
            Assert.IsNotNull(vm, "The created virtual machine should not be null.");
            Assert.IsInstanceOfType(vm, typeof(AWSVirtualMachine), "The created object should be of type AWSVirtualMachine.");
            Assert.AreEqual("AWS Virtual Machine Details: t2.micro, us-east-1, Is Running: False", vm.GetDetails(), "The virtual machine details should match the expected output.");
        }

        /// <summary>
        /// Tests if AWSFactory creates an instance of AWSDatabaseService.
        /// </summary>
        [TestMethod]
        public void AWSFactory_ShouldCreateDatabaseService()
        {
            // Act: Create a database service using the factory
            var db = _factory.CreateDatabaseService();

            // Assert: Verify the result
            Assert.IsNotNull(db, "The created database service should not be null.");
            Assert.IsInstanceOfType(db, typeof(AWSDatabaseService), "The created object should be of type AWSDatabaseService.");
            Assert.AreEqual("AWS Database Details: Engine MySQL, 10 GB, Encrypted: True, Running: False", db.GetDetails(), "The database details should match the expected output.");
        }

        /// <summary>
        /// Tests if AWSFactory creates an instance of AWSStorageService.
        /// </summary>
        [TestMethod]
        public void AWSFactory_ShouldCreateStorageService()
        {
            // Act: Create a storage service using the factory
            var storage = _factory.CreateStorageService();

            // Assert: Verify the result
            Assert.IsNotNull(storage, "The created storage service should not be null.");
            Assert.IsInstanceOfType(storage, typeof(AWSStorageService), "The created object should be of type AWSStorageService.");
            Assert.AreEqual("AWS Storage Details: SSD, 50 GB, Encrypted: True", storage.GetDetails(), "The storage service details should match the expected output.");
        }

        /// <summary>
        /// Tests if AWSFactory creates an instance of AWSVPC.
        /// </summary>
        [TestMethod]
        public void AWSFactory_ShouldCreateVNet()
        {
            // Act: Create a virtual private network using the factory
            var vpc = _factory.CreateVNet();

            // Assert: Verify the result
            Assert.IsNotNull(vpc, "The created VNet should not be null.");
            Assert.IsInstanceOfType(vpc, typeof(AWSVPC), "The created object should be of type AWSVPC.");
            Assert.AreEqual("AWS VPC Details: MyVPC, CIDR Block: 10.0.0.0/16, Configured: False", vpc.GetDetails(), "The VNet details should match the expected output.");
        }

        /// <summary>
        /// Tests if AWSFactory creates an instance of AWSSubnet.
        /// </summary>
        [TestMethod]
        public void AWSFactory_ShouldCreateSubnet()
        {
            // Act: Create a subnet using the factory
            var subnet = _factory.CreateSubnet();

            // Assert: Verify the result
            Assert.IsNotNull(subnet, "The created subnet should not be null.");
            Assert.IsInstanceOfType(subnet, typeof(AWSSubnet), "The created object should be of type AWSSubnet.");
            Assert.AreEqual("AWS Subnet Details: MySubnet, CIDR Block: 10.0.1.0/24, Configured: False", subnet.GetDetails(), "The subnet details should match the expected output.");
        }
    }
}

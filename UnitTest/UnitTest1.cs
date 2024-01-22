using BLL.Enums;
using BLL.Interfaces;
using BLL.Models;
using BLL.Models.AutoSchedule;
using Moq;

namespace ScheduleTests
{
    [TestClass]
    public class UnitTest1
    {

        private Mock<IShiftDataAccess> mockShiftDataAccess;

        [TestInitialize]
        public void Setup()
        {
            mockShiftDataAccess = new Mock<IShiftDataAccess>();
        }
        [TestMethod]
        public void CreateShift_ShouldCallInsertIntoDatabase()
        {
            // Arrange
            Shift shift = new Shift
            {
                Date = DateTime.Now,
                Shifttime = Shifttime.Morning
            };

            int id;
            mockShiftDataAccess
                .Setup(d => d.CreateShift(shift, out id))
                .Returns(true);

            // Act
            bool result = mockShiftDataAccess.Object.CreateShift(shift, out id);

            // Assert
            Assert.IsTrue(result);
            mockShiftDataAccess.Verify(d => d.CreateShift(shift, out id), Times.Once);
        }

        [TestMethod]
        public void GetShift_ShouldCallSelectFromDatabase()
        {
            // Arrange
            DateTime date = DateTime.Now;
            Shifttime shifttime = Shifttime.Morning;

            mockShiftDataAccess
                .Setup(d => d.GetShift(date, shifttime))
                .Returns(new Shift { Date = date, Shifttime = shifttime });

            // Act
            Shift? result = mockShiftDataAccess.Object.GetShift(date, shifttime);

            // Assert
            Assert.IsNotNull(result);
            mockShiftDataAccess.Verify(d => d.GetShift(date, shifttime), Times.Once);
        }

        [TestMethod]
        public void GetAllShifts_ShouldCallSelectAllFromDatabase()
        {
            // Arrange
            List<Shift> shifts = new List<Shift> { /* Add  shifts */ };

            mockShiftDataAccess
                .Setup(d => d.GetAllShifts())
                .Returns(shifts);

            // Act
            List<Shift> result = mockShiftDataAccess.Object.GetAllShifts();

            // Assert
            Assert.IsNotNull(result);
            mockShiftDataAccess.Verify(d => d.GetAllShifts(), Times.Once);
        }
        [TestMethod]
        public void GetShiftsBetweenDates_ShouldCallSelectBetweenDatesFromDatabase()
        {
            // Arrange
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddDays(7);

            List<Shift> shifts = new List<Shift> { /* Add  shifts  */ };

            mockShiftDataAccess
                .Setup(d => d.GetShiftsBetweenDates(startDate, endDate))
                .Returns(shifts);

            // Act
            List<Shift> result = mockShiftDataAccess.Object.GetShiftsBetweenDates(startDate, endDate);

            // Assert
            Assert.IsNotNull(result);
            mockShiftDataAccess.Verify(d => d.GetShiftsBetweenDates(startDate, endDate), Times.Once);
        }

        [TestMethod]
        public void GetAllShiftsByEmployee_ShouldCallSelectAllByEmployeeFromDatabase()
        {
            // Arrange
            int employeeId = 1;

            List<Shift> shifts = new List<Shift> { /* Add  shifts  */ };

            mockShiftDataAccess
                .Setup(d => d.GetAllShiftsByemp(employeeId))
                .Returns(shifts);

            // Act
            List<Shift> result = mockShiftDataAccess.Object.GetAllShiftsByemp(employeeId);

            // Assert
            Assert.IsNotNull(result);
            mockShiftDataAccess.Verify(d => d.GetAllShiftsByemp(employeeId), Times.Once);
        }

        [TestMethod]
        public void AssignEmployee_ShouldCallInsertIntoShiftHasEmployeeTable()
        {
            // Arrange
            Shift shift = new Shift { Id = 1 };
            Employee employee = new Employee { Id = 1 };

            mockShiftDataAccess
                .Setup(d => d.Assignemployee(shift, employee))
                .Returns(true);

            // Act
            bool result = mockShiftDataAccess.Object.Assignemployee(shift, employee);

            // Assert
            Assert.IsTrue(result);
            mockShiftDataAccess.Verify(d => d.Assignemployee(shift, employee), Times.Once);
        }

        [TestMethod]
        public void UnAssignEmployee_ShouldCallDeleteFromShiftHasEmployeeTable()
        {
            // Arrange
            Shift shift = new Shift { Id = 1 };
            Employee employee = new Employee { Id = 1 };

            mockShiftDataAccess
                .Setup(d => d.UnAssignEmployee(shift, employee))
                .Returns(true);

            // Act
            bool result = mockShiftDataAccess.Object.UnAssignEmployee(shift, employee);

            // Assert
            Assert.IsTrue(result);
            mockShiftDataAccess.Verify(d => d.UnAssignEmployee(shift, employee), Times.Once);
        }

        [TestMethod]
        public void GetAmountAssigned_ShouldCallSelectCountFromShiftHasEmployeeTable()
        {
            // Arrange
            Shift shift = new Shift { Id = 1 };

            mockShiftDataAccess
                .Setup(d => d.GetAmountassigned(shift))
                .Returns(3);

            // Act
            int result = mockShiftDataAccess.Object.GetAmountassigned(shift);

            // Assert
            Assert.AreEqual(3, result);
            mockShiftDataAccess.Verify(d => d.GetAmountassigned(shift), Times.Once);
        }

    }
}
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.AutoSchedule
{
    public class Shift
    {
        private int _id;
        private DateTime _date;
        private Enums.Shifttime _shifttime;
        private List<Employee> _employee;

        public Shift(DateTime Date, Enums.Shifttime Shifttime, List<Employee>? Employee = null)
        {
            _date = Date;
            _shifttime = Shifttime;
            if (Employee != null)
            {
                _employee = Employee;
            }
        }
        public Shift()
        {

        }
        public int Id
        {
            get
            {

                return _id;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _id = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public Enums.Shifttime Shifttime
        {
            get
            {
                return _shifttime;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _shifttime = value;
            }
        }
        public List<Employee> Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _employee = value;
            }
        }
    }
}

using System;

namespace VerySimpleTaskList
{
    public class TaskWithReminder : Task
    {
        public TaskWithReminder(string description, int numberHours)  //constructor
            : base(description)
        {
            _numberOfHours = numberHours; 
        }

        public override string DescribeYourself()
        {
            string parentsDescription = base.DescribeYourself();
            return $"{parentsDescription} and I will remind you in {_numberOfHours} hour(s).";
        }


        private int _numberOfHours;
    }
}

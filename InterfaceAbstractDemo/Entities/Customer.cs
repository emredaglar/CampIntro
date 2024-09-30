using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        //somut sınıflar çıplak kalmamalı.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public long NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}


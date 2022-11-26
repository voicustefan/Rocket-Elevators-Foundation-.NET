using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Models
{
    public class Intervention
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? CustomerID { get; set; }
        public string? BuildingID{get; set;}
        public string? BatteryID{get; set;}
        public string? ColumnID{get; set;}
        public string? ElevatorID{get; set;}
        public string? EmployeeID{get; set;}
        public string? StartDate{get; set;}
        public string? EndDate{get; set;}
        public string? Result{get; set;}
        public string? Report{get; set;}
        public string Status{get; set;}


    }
    }
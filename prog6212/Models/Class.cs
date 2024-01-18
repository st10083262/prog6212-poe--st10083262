using System.ComponentModel.DataAnnotations;

namespace progfinal11111.Models
{
    public class Class
    
        
    {

            public string? Username { get; set; }
            [Key]
            public string? ModuleCode { get; set; }
            public string? ModuleName { get; set; }
            public int Credits { get; set; }
            public int Hoursperweek { get; set; }
            public int Weekspersemester { get; set; }

            public string? StartDate { get; set; }
            public string? Hoursspent { get; set; }

        }
    }

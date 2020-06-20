using System.ComponentModel.DataAnnotations;

namespace Commander.Models{

public class Command 
{
    public int id { get; set; }

    [Required]
    public string howTo { get; set; }
    
    [Required]
    public string line { get; set; }

    [Required]
    public string platform { get; set; }

}

}
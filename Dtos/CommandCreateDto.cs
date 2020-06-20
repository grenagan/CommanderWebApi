using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos 
{
   public class CommandCreateDto 
{

    [Required]
    public string howTo { get; set; }
    
    [Required]
    public string line { get; set; }

    [Required]
    public string platform { get; set; }

}



}

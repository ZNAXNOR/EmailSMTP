using System.ComponentModel.DataAnnotations;

namespace EmailSMTP.ViewModels
{
    public class EmailViewModel
    {
        //Email
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //Subject
        [Required]        
        public string Subject { get; set; }

        //Message
        [Required]
        public string Message { get; set; }
    }
}

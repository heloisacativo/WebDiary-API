using System.ComponentModel.DataAnnotations;

namespace WebDiary_API.Models
{
    public class DiaryEntry_cs
    {
        public int Id { get; set; }
       
        public string Title { get; set; } = String.Empty;
        
        public string Content { get; set; } = String.Empty;
      
        public DateTime Created { get; set; } = DateTime.Now;
    }
}

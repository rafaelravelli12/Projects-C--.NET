//M�dulo 1
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Blog.Models
//{
//    [Table("Post")]
//    public class Post
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public int Id { get; set; }
//        [ForeignKey("CategoryId")]
//        public int CategoryId { get; set; }
//        public Category Category { get; set; }
//        [ForeignKey("AuthorId")]
//        public int AuthorId { get; set; }
//        public User Author { get; set; }
//        public string Title { get; set; }
//        public string Summary { get; set; }
//        public string Body { get; set; }
//        public string Slug { get; set; }
//        public DateTime CreateDate { get; set; }
//        public DateTime LastUpdateDate { get; set; }
//    }
//}

//M�dulo 2
using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }            
        public int AuthorId { get; set; }            
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public Category Category { get; set; }
        public User Author { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
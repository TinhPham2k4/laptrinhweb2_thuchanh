﻿using laptrinhweb2_thuchanh.Models;
using System.ComponentModel.DataAnnotations;

namespace laptrinhweb2_thuchanh.Models.Domain
{
    public class Book_Author
    {
        [Key]
        public int Book_AuthorId { get; set; }
        public Books? Books { get; set; }
        public int BooksId { get; set; }
        public Authors? Authors { get; set; }
        public int AuthorsId { get; set; }
    }
}
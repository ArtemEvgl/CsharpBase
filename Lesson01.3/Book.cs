using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01._3
{
    class Book
    {
        Author author;
        Content content;
        Title title;

        public Book(string author, string content, string title)
        {
            this.author = new Author(author);
            this.content = new Content(content);
            this.title = new Title(title);
        }

        public void Show()
        {
            author.Show();
            content.Show();
            title.Show();
        }

        
    }
}

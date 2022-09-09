using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class CardContentcs
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public string Person { get; set; }

        public string Size {get; set; } 
        
        public string BoardType { get; set; } = "ToDo";

        public CardContentcs(string Header,string Content, string Person, string BoardType,string Size)
        {
            this.Header = Header;
            this.Person=Person;
            this.Content = Content; 
            this.BoardType = BoardType; 
            this.Size = Size;   
        }
        public CardContentcs()
        {

        }



    }
}

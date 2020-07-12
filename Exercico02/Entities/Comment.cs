using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Exercico02.Entitis
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }

}

﻿using System.Collections.Generic;

namespace HTML
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Comments { get; set; }

        public Article()
        {
            Comments = new List<string>();
        }
    }
}

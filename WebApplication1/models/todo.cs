using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Todo.Website.Models
{
    public class Todo
    {
        public string Id {get; set;}
        public string Data { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Todo>(this);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// The Id property functions as the unique key in a relational database.
        /// </summary>
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        /// <summary>
        /// A secret added to the model. This must not be exposed in the API responses.
        /// </summary>
        public string Secret { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAPI
{

    public class User
    {
        [Required(ErrorMessage = "userId is a required field")]
        public int userId { get; set; }

        [Required(ErrorMessage = "id is a required field")]
        public int id { get; set; }

        [Required(ErrorMessage = "title is a required field")]
        public string title { get; set; }

        [Required(ErrorMessage = "completed is a required field")]
        public bool completed { get; set; }
    }

}

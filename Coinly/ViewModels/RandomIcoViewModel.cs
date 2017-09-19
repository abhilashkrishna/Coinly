using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Coinly.Models;

namespace Coinly.ViewModels
{
    public class RandomIcoViewModel
    {
        public Ico Ico { get; set; }
        public List<Customer> Customer { get; set; }
    }
}
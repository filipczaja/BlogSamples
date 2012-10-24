using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWebService
{
    public class StringService : IStringService
    {
        public string ReverseString(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}

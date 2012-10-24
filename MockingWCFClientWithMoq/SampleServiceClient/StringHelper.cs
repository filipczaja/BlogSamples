using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using SampleServiceClient.SampleWebService;

namespace SampleServiceClient
{
    public class StringHelper
    {
        IStringServiceChannel _client;

        public StringHelper()
        {
            var factory = new ChannelFactory<IStringServiceChannel>("BasicHttpBinding_IStringService");
            _client = factory.CreateChannel(); 
        }

        public StringHelper(IStringServiceChannel client)
        {
            _client = client;
        }

        public async Task<string> ReverseAsync(string input)
        {
            return await _client.ReverseStringAsync(input);
        }
    }
}

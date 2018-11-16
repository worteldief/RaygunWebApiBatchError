using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RaygunWebApiBatchError
{
    public class BatchServer : HttpServer
    {
        private readonly HttpConfiguration m_Configuration;

        public BatchServer(HttpConfiguration configuration) : base(configuration)
        {
            m_Configuration = configuration;
        }

        protected override void Initialize()
        {
            var firstInPipeline = m_Configuration.MessageHandlers.FirstOrDefault();

            if (firstInPipeline != null && firstInPipeline.InnerHandler != null)
            {
                InnerHandler = firstInPipeline;
            }
            else
            {
                base.Initialize();
            }
        }
    }
}
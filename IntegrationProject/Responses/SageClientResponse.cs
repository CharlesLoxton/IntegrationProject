﻿using IntegrationProject.Interfaces;

namespace IntegrationProject.Responses
{
    internal class SageClientResponse : IResponse
    {
        public string? response_Id { get; set; }
        public int companyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
    }
}

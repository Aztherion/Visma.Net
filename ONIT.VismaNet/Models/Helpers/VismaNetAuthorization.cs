﻿namespace ONIT.VismaNetApi.Models
{
    public class VismaNetAuthorization
    {
        public string Token { get; set; }
        public int CompanyId { get; set; }
        public bool UseProxy { get; set; }
    }
}
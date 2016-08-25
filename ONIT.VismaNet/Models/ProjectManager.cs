﻿using System.Collections.Generic;

namespace ONIT.VismaNetApi.Models
{
    public class ProjectManager : Employee, IProvideCustomDto
    {
        public override Dictionary<string, object> ToDto()
        {
            return new Dictionary<string, object>()
            {
                {"value", number}
            };
        }

        object IProvideCustomDto.ToDto()
        {
            return new DtoValue(number);
        }
    }
}
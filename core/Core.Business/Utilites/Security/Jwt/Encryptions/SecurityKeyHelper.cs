﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Core.Business.Utilites.Security.Jwt.Encryptions
{
    public  class SecurityKeyHelper 
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        { 
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
    
       
        
    
}

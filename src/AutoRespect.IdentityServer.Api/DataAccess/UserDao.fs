namespace AutoRespect.IdentityServer.Api.DataAccess

open AutoRespect.IdentityServer.Api.Models.Domain

module UserDao =
    let findByLogin login =     
        
        { Id = 0; Login = "HardCode@outlook.com"; Password = "123456" }
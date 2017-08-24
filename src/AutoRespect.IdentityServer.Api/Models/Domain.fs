namespace AutoRespect.IdentityServer.Api.Models

open System

module Domain =

    type User = 
        {   Id: int
            Login: string
            Password: string }

    type Token =
        {   AccessToken: string
            RefreshToken: string 
            ExpiresIn: DateTime }        
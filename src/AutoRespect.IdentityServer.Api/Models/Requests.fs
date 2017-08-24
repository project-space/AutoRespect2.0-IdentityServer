namespace AutoRespect.IdentityServer.Api.Models

open System

module Requests =

    [<CLIMutable>]
    type AccessTokenRequest =
        {   grant_type: string
            (* password flow begin *) 
            username: string
            password: string
            (* password flow end*)
            scope: string }
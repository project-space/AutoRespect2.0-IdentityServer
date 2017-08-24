namespace AutoRespect.IdentityServer.Api.DataAccess

open System.Data.SqlClient
open Dapper 

module Connection =

    let connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Integrated Security = True;"
    
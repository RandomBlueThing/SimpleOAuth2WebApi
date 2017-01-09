using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer
{
	static class Scopes
	{
		/*
			Registering the API
			APIs are modeled as scopes - you need to register all APIs that you want to be able to request access tokens for. 
			For that we create a class that returns a list of Scope:
		*/
		public static List<Scope> Get()
		{
			return new List<Scope>()
			{
				new Scope()
				{
					Name = "api1"
				}
			};
		}
	}
}

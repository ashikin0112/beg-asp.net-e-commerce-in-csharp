// UrlRewriter - A .NET URL Rewriter module
// Version 2.0
//
// Copyright 2007 Intelligencia
// Copyright 2007 Seth Yates
// 

using System;
using System.Net;

namespace Intelligencia.UrlRewriter.Actions
{
	/// <summary>
	/// Returns a 501 Not Implemented HTTP status code.
	/// </summary>
	public sealed class NotImplementedAction : SetStatusAction
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NotImplementedAction() : base(HttpStatusCode.NotImplemented)
		{
		}
	}
}

using System;
namespace Core.Utilities.Results.Abstracts
{
	public interface IDataResult<T> : IResult
	{
		T Data { get; }
	}
}


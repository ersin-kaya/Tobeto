namespace Core.Utilities.Results.Concretes
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {

        }

        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }
        public Result(bool success, string message):this(success) // dışarıdan değil const dan set edilebilir bir yapı
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
      
    }
}

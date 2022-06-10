using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DTOs
{
    public class ApiResponseDto<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }


        public static ApiResponseDto<T> SuccessResponse(T data, string message = null, int status = 200)
        {
            return new ApiResponseDto<T> { Data = data, Message = message, Status = status };
        }
        public static ApiResponseDto<T> SuccessEmpty(string message = null, int status = 200)
        {
            return new ApiResponseDto<T> { Message = message, Status = status };
        }
        public static ApiResponseDto<T> FailedResponse(string message, int status = 400)
        {
            return new ApiResponseDto<T> { Message = message, Status = status };
        }

        public bool IsSucces { get { return Status == 200; } }
    }
}

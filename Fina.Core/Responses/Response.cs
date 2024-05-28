using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class Response<TDataResponse>
{
    private readonly int _code;

    [JsonConstructor]
    public Response() => _code = Configuration.DefaultStatuCode;
    
    public Response(TDataResponse? data, 
        int statuCode = Configuration.DefaultStatuCode, 
        string? message = null)
    {
        Message = message;
        Data = data;
        _code = statuCode;
    }

    public string? Message { get; set; }
    public TDataResponse? Data { get; set; }

    [JsonIgnore] 
    public bool IsSucess => _code is >= 200 and <= 299;
}
namespace AccCareer.DAL.Cqs.Data;

public class Request: IRequest
{

    public Request()
    {
        CorrelationId = Guid.NewGuid();
    }
    public Guid CorrelationId { get; set; }
}
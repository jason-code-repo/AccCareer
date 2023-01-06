namespace AccCareer.DAL.Cqs.Data;

public interface IRequest
{
    Guid CorrelationId { get; set; }
}